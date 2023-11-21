import asyncio
import json
  

class Seat:
    def __init__(self, seatNum, user, remaining_time, connection=None):
        self.seatNum = seatNum
        self.user = user
        self.connection = None

        self.remaining_time = int(remaining_time) if remaining_time is not None else remaining_time
        self.lock = asyncio.Lock()  # Add a lock for each seat

    def __repr__(self):
        connection_status = "Connected" if self.connection else "No Connection"
        return f"[{self.seatNum} : {self.user}, {self.remaining_time}]"

class UserManager:
    def __init__(self, db):
        self.db = db

    async def initialize(self):
        query = "SELECT SeatNumber, UserID, UsageTime FROM Seat ORDER BY SeatNumber"
        seat_records = await self.db.execute_query(query)
        self.seats = {seatNum: Seat(seatNum, user, status) for seatNum, user, status in seat_records}

    async def get_user(self, user_id):
        query = "SELECT * FROM Member WHERE ID = %s"
        result = await self.db.fetch_one(query, (user_id,))
        return result

    async def add_user(self, user_id, seat_num, connection):
        seat = self.seats[seat_num]
        async with seat.lock:
            if self.seats[seat_num].user != None:
                print("another user is already using the seat")
                # handle error here
                return

            user_data = await self.get_user(user_id)
            if user_data:
                id, _, _, _, remaining_sec, _, _, _ = user_data
                seat.user = user_id
                seat.remaining_time = remaining_sec
                seat.connection = connection

                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (remaining_sec, user_id, seat_num)
                await self.db.execute_query(query, params, commit=True)

                print(f'user {id} is active')
            else:
                print(f'user {user_id} not found')
                # handle error here

                return
        
    async def reserve_user(self, user_id, seat_num, connection):
        seat = self.seats[seat_num]
        async with seat.lock:
            if seat.user is not None:
                print("Another user is already using the seat")
                return

            user_data = await self.get_user(user_id)
            if user_data:
                id, _, _, _, _, _, _, _ = user_data
                seat.user = user_id
                seat.remaining_time = -1
                seat.connection = connection
                
                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (-1, user_id, seat_num)
                await self.db.execute_query(query, params, commit=True)

                print(f'user {id} is reserved')
            else:
                print(f'user {user_id} not found')
                # handle error here

                return


    async def remove_user(self, user_id, seat_num, websocket):
        seat = self.seats.get(seat_num)
        if not seat:
            print("Invalid seat num")
            return

        async with seat.lock:
            if seat.user == user_id:
                seat.user = None
                seat.remaining_time = 0

                # Close the WebSocket connection if it exists
                # if seat.connection:
                #     try:
                #         await seat.connection.close()
                #         print(f"WebSocket connection closed for seat {seat_num}")
                #     except Exception as e:
                #         print(f"Error closing WebSocket connection for seat {seat_num}: {e}")
                #     finally:
                #         seat.connection = None  # Reset the connection attribute


                query = "UPDATE Seat SET UsageTime = %s, UserID = %s WHERE SeatNumber = %s"
                params = (None, None, seat_num)
                await self.db.execute_query(query, params, commit=True)


                print(f'user {user_id} is deactive')
            else:
                print(f'user {user_id} not found in active users')
                # handle error

    async def update_member_table(self, seat):
        query = "UPDATE Member SET RemainingHours = %s WHERE ID = %s"
        params = (seat.remaining_time, seat.user)
        await self.db.execute_query(query, params, commit=True)
        # print(f"Updated Memeber table for user {seat.user} : {seat.remaining_time}")
        
        
    async def update_seat_table(self, seat):
        query = "UPDATE Seat SET UsageTime = %s WHERE UserID = %s"
        params = (seat.remaining_time, seat.user)
        await self.db.execute_query(query, params, commit=True)
        # print(f"Updated Seat table for user {seat.user} : {seat.remaining_time}")
        
    async def get_remaining_hours(self, user_id):
        query = "SELECT RemainingHours FROM Member WHERE ID = %s"
        result = await self.db.fetch_one(query, (user_id,))
        return result[0] if result else None

    
    async def decrement_time(self, seat):
        async with seat.lock:
            # Decrement the remaining time
            seat.remaining_time -= 1

            await self.update_seat_table(seat)
            await self.update_member_table(seat)

        if seat.remaining_time < 0:
            if seat.connection:
                try:
                    # await seat.connection.send("Your remaining time is 0. Please vacate the seat.")
                    message = self.build_json({"command": "logout"})
                    await self.send_json(message, seat.connection)
                except Exception as e:
                    print(f"Error sending message to client: {e}")
                finally:
                    seat.user = None
                    seat.remaining_time = None
                    # Optionally, you can close the connection here if needed
                    # await seat.connection.close()
            
            await self.remove_user(seat.user, seat.seatNum, seat.connection)

    def build_json(self, data):
        try:
            return json.dumps(data)
        except TypeError as e:
            print(f"Error in building JSON: {e}")
            return None

    async def send_json(self, json_string, connection):
        if not json_string or not connection:
            print("Invalid input for sending JSON")
            return

        try:
            await connection.send(json_string)
        except Exception as e:
            print(f"Error sending JSON to client: {e}")

    async def decrement_all_seats(self):
        for seat in self.seats.values():
            if seat.user is not None and seat.remaining_time is not None and seat.remaining_time >= 0:
                await self.decrement_time(seat)

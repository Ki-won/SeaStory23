﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static SeaStory.Model.DataCalss;

namespace SeaStory.Model
{

    class DatabaseAut
    {

        private static string connStr = "server=webp.flykorea.kr;user=story;database=storyDB;port=13306;password=sea@#21;";
        private static MySqlConnection conn = new MySqlConnection(connStr);

        //회원 가입된 유저인지 확인하는 메소드, 있으면 1 없으면 -1을 반환한다.
        internal static int UserCheck(string Id, string Pw)
        {
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Member WHERE ID = @Id AND Password = @Pw";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Pw", Pw);

                object count = cmd.ExecuteScalar();

                if (count != null && Convert.ToInt32(count) > 0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }

        //중복확인을 위해 유저 ID를 확인하는 메소드, 있으면 1 없으면 -1을 반환한다.
        internal static int IDCheck(string Id)
        {
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Member WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);
                object count = cmd.ExecuteScalar();

                if (count != null && Convert.ToInt32(count) > 0)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }

        //일치하는 아이디의 회원정보를 모두 반환한다 .
        public static User UserData(string Id)
        {
            MessageBox.Show("called");
            User user = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Member WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", Id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    user = new User();

                    if (reader.Read())
                    {
                        user.Name = reader["Username"].ToString();
                        user.PhoneNumber = reader["PhoneNumber"].ToString();
                        user.Time = reader["RemainingTime"].ToString();
                        user.UsedTime = reader["UsageTime"].ToString(); 
                        user.LoginType = reader["LoginType"].ToString();
                        user.UserType = Convert.ToBoolean(reader["IsAdmin"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return user;
        }


        //일치하는 아이디의 회원을 삭제하는 함수 .
        public static void DeleteMember(string memberId)
        {
            try
            {
                conn.Open();
                string sql = "DELETE FROM Member WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", memberId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting member: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        
        //랭크를 반환하는 함수 아이디 이름 사용시간 반환 
        public static List<User2> GetRanking()
        {
            List<User2> ranking = new List<User2>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Member ORDER BY UsageTime DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User2 user = new User2
                        {
                            ID = reader["ID"].ToString(),
                            Name = reader["Username"].ToString(),
                            UsedTime = Convert.ToInt32(reader["UsageTime"])
                        };

                        ranking.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return ranking;
        }
        //모든회원의 아이디 이름 비밀번호 남은시간 사용시간 반환 함수 
        public static List<User2> GetAllMembers()
        {
            List<User2> members = new List<User2>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Member";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User2 user = new User2
                        {
                            ID = reader["ID"].ToString(),
                            Name = reader["Username"].ToString(),
                            PW = reader["Password"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            RemainingTime = Convert.ToInt32(reader["RemainingTime"]),
                            UsedTime = Convert.ToInt32(reader["UsageTime"]),
                        };

                        members.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return members;
        }

        //회원가입을 위해 유저 ID, PW, 이름, 연락처를 받고 DB에 새로운 회원을 생성하는 함수
        public static void RegisterUser(string userId, string name, string password,  string phoneNumber)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO Member (ID, Username, Password, PhoneNumber) VALUES (@Id, @Username, @Password, @PhoneNumber)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.Parameters.AddWithValue("@Username", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error registering user: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //유저 ID를 넣으면 유저의 잔여 시간을 반환해주는 함수
        public static int GetUesrTime(string userId)
        {
            int remainingHours = -1;

            try
            {
                conn.Open();
                string sql = "SELECT RemainingTime FROM Member WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", userId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    remainingHours = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting remaining hours: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return remainingHours; //값을 못받으면 -1을 반환한다.
        }
        // 비회원 시간 반환하는함수도 추가 

        public static void SetUserTime(string userId, int time)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE Member SET RemainingTime = @time WHERE ID = @Id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery(); // Execute the command
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating time: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //id에 대하여 소모시간을 5더하고 남은시간을 5 차감하는 메소드
        // 시간 소모관련하여서 사용하시면됨
        public static void SpendTime(string userId)
        {
            try
            {
                conn.Open();
                string updateSql = "UPDATE Member SET UsageTime = UsageTime + 1, RemainingTime = RemainingTime - 1 WHERE ID = @Id";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@Id", userId);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating usage time: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //비회원 시간 깍기 추가

        // 회원ID를 입력받고 비밀번호 이름 연락처를 정보를 수정하는 메소드
        public static void UpdateUser(string userId, string password, string name, string phoneNumber)
        {
            try
            {
                conn.Open();
                string updateSql = "UPDATE Member SET Password = @Password, Username = @Username, PhoneNumber = @PhoneNumber WHERE ID = @Id";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@Id", userId);
                updateCmd.Parameters.AddWithValue("@Password", password);
                updateCmd.Parameters.AddWithValue("@Username", name);
                updateCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //SeatNumber와 UserID를 입력받아 UserID에는 입력받은 유저 ID를, UsageTime에는 회원의 남은시간을 넣는 메소드
        public static void UpdateSeatInfo(int seatNumber, string userId)
        {
            try
            {
                conn.Open();
                string updateSql = "UPDATE Seat SET UserID = @UserId, UsageTime = (SELECT RemainingTime FROM Member WHERE ID = @UserId) WHERE SeatNumber = @SeatNumber";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                updateCmd.Parameters.AddWithValue("@UserId", userId);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating seat information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //SubscriptionKey를 입력받아 요금제 정보를 수정하는 메소드
        public static void UpdateSubscriptionInfo(string subscriptionKey, int newAmount, int newHours)
        {
            try
            {
                conn.Open();
                string updateSql = "UPDATE Subscription SET SubscriptionAmount = @NewAmount, SubscriptionHours = @NewHours WHERE SubscriptionKey = @SubscriptionKey";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@SubscriptionKey", subscriptionKey);
                updateCmd.Parameters.AddWithValue("@NewAmount", newAmount);
                updateCmd.Parameters.AddWithValue("@NewHours", newHours);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating subscription information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //SubscriptionKey를 입력받아 요금제 정보를 삭제하는 메소드
        public static void DeleteSubscription(string subscriptionKey)
        {
            try
            {
                conn.Open();
                string deleteSql = "DELETE FROM Subscription WHERE SubscriptionKey = @SubscriptionKey";
                MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn);
                deleteCmd.Parameters.AddWithValue("@SubscriptionKey", subscriptionKey);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting subscription information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //FoodCode를 입력받아 음식정보들을 수정하는 메소드
        public static void UpdateFoodInfo(string foodCode, string newName, int newPrice, string newImageUrl)
        {
            try
            {
                conn.Open();
                string updateSql = "UPDATE Food SET FoodName = @NewName, FoodPrice = @NewPrice, ImageURL = @NewImageUrl WHERE FoodCode = @FoodCode";
                MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                updateCmd.Parameters.AddWithValue("@FoodCode", foodCode);
                updateCmd.Parameters.AddWithValue("@NewName", newName);
                updateCmd.Parameters.AddWithValue("@NewPrice", newPrice);
                updateCmd.Parameters.AddWithValue("@NewImageUrl", newImageUrl);

                updateCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating food information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //FoodCode를 해당 음식을 삭제하는 메소드
        public static void DeleteFood(string foodCode)
        {
            try
            {
                conn.Open();
                string deleteSql = "DELETE FROM Food WHERE FoodCode = @FoodCode";
                MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn);
                deleteCmd.Parameters.AddWithValue("@FoodCode", foodCode);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting food information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void AddOrder(string foodCode, string orderSeat)
        {
            try
            {
                string insertSql = "INSERT INTO OrderTable (FoodCode, OrderSeat) VALUES (@FoodCode, @OrderSeat)";
                MySqlCommand insertCmd = new(insertSql, conn);
                insertCmd.Parameters.AddWithValue("@FoodCode", foodCode);
                insertCmd.Parameters.AddWithValue("@OrderSeat", orderSeat);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show($"주문성공했습니다.\nFood Code: {foodCode}\nOrder Seat: {orderSeat}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"주문실패했습니다.\n{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        //Foodcode와 주문자리 정보를 받아 삭제하는 메소드
        public static void DeleteOrder(string orderSeat)
        {
            try
            {
                conn.Open();
                string deleteSql = "DELETE FROM OrderTable WHERE OrderSeat = @OrderSeat";
                MySqlCommand deleteCmd = new MySqlCommand(deleteSql, conn);
                deleteCmd.Parameters.AddWithValue("@OrderSeat", orderSeat);

                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting order information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //음식 이름을 넣으면 코드를 반환하는 함수
        public static string GetFoodCode(string foodName)
        {
            try
            {
                {
                    conn.Open();
                    string sql = "SELECT FoodCode FROM Food WHERE FoodName = @FoodName";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@FoodName", foodName);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting food code: " + ex.Message);
            }

            return null; // 해당 음식이 없는 경우
        }
    }//aut 필드
}//네임필드



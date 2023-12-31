import aiomysql
import logging

# Assuming the logging configuration is done in your main program.
logger = logging.getLogger(__name__)


class Database:
    def __init__(self, loop, config):
        self.loop = loop
        self.config = config
        self.pool = None

    async def connect(self):
        logger.debug("Connecting to the database")
        # Create a pool of connections
        self.pool = await aiomysql.create_pool(loop=self.loop, **self.config)
        logger.debug("Database connection established")

    async def execute_query(self, query, params=None, commit=False):
        logger.debug(f"Executing query: {query}, Params: {params}")
        # Acquire a connection from the pool
        async with self.pool.acquire() as conn:
            async with conn.cursor() as cursor:
                await cursor.execute(query, params or ())
                if query.strip().upper().startswith("SELECT"):
                    result = await cursor.fetchall()
                    logger.debug(f"Query result: {result}")
                    return result
                elif commit:
                    await conn.commit()
                    logger.debug("Query committed")

    async def fetch_one(self, query, params=None):
        logger.debug(f"Fetching one: {query}, Params: {params}")
        # Acquire a connection from the pool
        async with self.pool.acquire() as conn:
            async with conn.cursor() as cursor:
                await cursor.execute(query, params or ())
                result = await cursor.fetchone()
                logger.debug(f"Fetched one result: {result}")
                return result

    async def close(self):
        logger.debug("Closing database connection")
        # Close the pool of connections
        self.pool.close()
        await self.pool.wait_closed()
        logger.debug("Database connection closed")



using System.Data.SQLite;
using System.IO;


public static class DatabaseHelper
{
    private static string connectionString = @"Data Source=Snake.db;Version=3;";

    public static void InitializeDatabase()
    {
        if (!File.Exists(@"Snake.db"))
        {
            SQLiteConnection.CreateFile(@"Snake.db");
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create tables for database
                string createSnakeDataTableQuery = @"
                    CREATE TABLE IF NOT EXISTS SnakeData (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        username TEXT NOT NULL,
                        score INTEGER NOT NULL,
                        time INTEGER NOT NULL,
                        difficulty TEXT NOT NULL
                    );";

                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = createSnakeDataTableQuery;
                    command.ExecuteNonQuery();
                }
            }
        }
        else
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Insert data into the table
                string createSnakeDataTableQuery = @"
                INSERT INTO SnakeData (username, score, time, difficulty) VALUES ('test', 59, 800, 'easy');
                ";

                using (var command = new SQLiteCommand(createSnakeDataTableQuery, connection))
                {
                    command.CommandText = createSnakeDataTableQuery;
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("tes");
            Console.ReadLine();
        }
    }
}
using System.Data.SQLite;
using System.IO;


public static class DatabaseHelper
{
    private static string connectionString = @"Data Source-..\..\files\Snake.db;Version=3;";

    public static void InitializeDatabase()
    {
        if (!File.Exists(@"..\..\files\Snake.db"))
        {
            SQLiteConnection.CreateFile(@"..\..\files\Snake.db");
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
    }
}
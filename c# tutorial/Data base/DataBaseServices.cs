using System.Data.SQLite;

namespace c__tutorial.Data_base
{

    public class DataBaseServices
    {
        public void CreateUsersTable()
        {
            SQLiteConnection connection = DataBase.Instance.Connection;
            string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                    UsersId INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserName TEXT NOT NULL,
                    UserAddress TEXT,
                    UserEmail TEXT,
                    UserPhoneNumber TEXT,

                    -- Employee-specific columns (optional)
                    Position TEXT,
                    Salary REAL,

                    -- Customer-specific columns (optional)
                    CreditCard TEXT
                     );";

            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            DataBase.Instance.Close();

        }

        public void DropTable(string tableName)
        {
            SQLiteConnection connection = DataBase.Instance.Connection;

            string dropQuery = $"DROP TABLE IF EXISTS {tableName};";

            using (var command = new SQLiteCommand(dropQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            DataBase.Instance.Close();
        }
    }
}

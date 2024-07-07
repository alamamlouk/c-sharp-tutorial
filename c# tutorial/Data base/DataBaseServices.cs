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
        public void CreateProductsTable()
        {
            SQLiteConnection connection = DataBase.Instance.Connection;

            string createProductsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Products (
                    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT NOT NULL,
                    ProductDescription TEXT NOT NULL,
                    ProductPrice REAL NOT NULL
                );";
            using (var command = new SQLiteCommand(createProductsTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            DataBase.Instance.Close();
        }
        public void CreateProductBoughtTable()
        {
            SQLiteConnection connection = DataBase.Instance.Connection;

            string createProductsBoughtTableQuery = @"
                CREATE TABLE IF NOT EXISTS ProductsBought (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserId INTEGER NOT NULL,
                    ProductID INTEGER NOT NULL,
                    FOREIGN KEY (ProductId) REFERENCES Products(Id),
                    FOREIGN KEY (UserId) REFERENCES Users(UsersId)
                );";
            using (var command = new SQLiteCommand(createProductsBoughtTableQuery, connection))
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

using System;
using System.Data.Common;
using System.Data.SQLite;

namespace c__tutorial.Data_base
{
    public sealed class DataBase
    {

        private static readonly DataBase instance = null;
        private SQLiteConnection SQLite_conn;
        private static readonly object lockObject = new object();

        private DataBase()
        {
            SQLite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
        }

        public SQLiteConnection Connection
        {
            get
            {
                if (SQLite_conn.State == System.Data.ConnectionState.Closed)
                {
                    SQLite_conn.Open();
                }
                return SQLite_conn;
            }
        }
        public static DataBase Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        return new DataBase();
                    }
                    return instance;
                }
            }
        }
        public void Close()
        {
            if(SQLite_conn.State != System.Data.ConnectionState.Closed)
            {
                SQLite_conn.Close();

            }
        }
      

    }
}

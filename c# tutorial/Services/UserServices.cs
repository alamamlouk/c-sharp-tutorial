using c__tutorial.Data_base;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial.Services
{
    public class UserServices
    {
        SQLiteConnection connection = DataBase.Instance.Connection;

        public void Login()
        {

                

        }
        public void Registration(string UserName, string UserAddress, string UserEmail, string UserPhoneNumber, string CreditCard = null, string position = null, float salary = 0f)
        {
            StringBuilder registrationQuery = new StringBuilder();
            registrationQuery.Append("INSERT INTO Users (UserName, UserAddress, UserEmail, UserPhoneNumber");

            if (CreditCard != null)
            {
                registrationQuery.Append(", CreditCard");
            }
            if (position != null)
            {
                registrationQuery.Append(", Position");
            }
            if (salary != 0.0f)
            {
                registrationQuery.Append(", Salary");
            }

            registrationQuery.Append(") VALUES (");
            registrationQuery.Append("@UserName, @UserAddress, @UserEmail, @UserPhoneNumber");

            if (CreditCard != null)
            {
                registrationQuery.Append(", @CreditCard");
            }
            if (position != null)
            {
                registrationQuery.Append(", @Position");
            }
            if (salary != 0.0f)
            {
                registrationQuery.Append(", @Salary");
            }

            registrationQuery.Append(")");

            using (SQLiteCommand command = new SQLiteCommand(registrationQuery.ToString(), connection))
            {
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@UserAddress", UserAddress);
                command.Parameters.AddWithValue("@UserEmail", UserEmail);
                command.Parameters.AddWithValue("@UserPhoneNumber", UserPhoneNumber);
                if (CreditCard != null)
                {
                    command.Parameters.AddWithValue("@CreditCard", CreditCard);
                }
                if (position != null)
                {
                    command.Parameters.AddWithValue("@Position", position);
                }
                if (salary != 0f)
                {
                    command.Parameters.AddWithValue("@Salary", salary);
                }
                command.ExecuteNonQuery();
            }
            DataBase.Instance.Close();
        }
        public void RemoveUser()
        {
           Console.WriteLine("User removed");
        }
        public void ReadUser()
        {
            SQLiteConnection connection = DataBase.Instance.Connection;
            string readQuery = "SELECT * FROM Users";
            using (SQLiteCommand command = new SQLiteCommand(readQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(@"
                        ID: " + reader["UsersId"] + 
                        " UserName: " + reader["UserName"] + 
                        " UserAddress: " + reader["UserAddress"] +
                        " UserEmail: " + reader["UserEmail"] +
                        " UserPhoneNumber: " + reader["UserPhoneNumber"] + 
                        " CreditCard: " + reader["CreditCard"] +
                        " Position: " + reader["Position"] + 
                        " Salary: " + reader["Salary"]);
                    }
                }
            }
        }
    }
}

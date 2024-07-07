using c__tutorial.Data_base;
using c__tutorial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class StoreProgramWithSQLite
    { 

        public void Run()
        {
            DataBaseServices databaseService = new DataBaseServices();
            try
            {
                databaseService.CreateUsersTable();
                databaseService.CreateProductsTable();
                databaseService.CreateProductBoughtTable();
                Console.WriteLine("Table created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            //Create a user 
            UserServices userServices = new UserServices();
            userServices.Registration("Ala", "Tunis", "alaa@gmail.com", "123456789", position: "Owner", salary: 10000);
            userServices.ReadUser();

        }
    }
}

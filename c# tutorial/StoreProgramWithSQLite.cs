using c__tutorial.Data_base;
using c__tutorial.Services;
using System;

namespace c__tutorial
{
    public class StoreProgramWithSQLite
    {

        public void Run()
        {

            ConnectToDataBase();
            //Create a user 
            //Choose login or SignUp
            Console.WriteLine("Welcome to the store program");
            Console.WriteLine("1- Login");
            Console.WriteLine("2- SignUp");
            Console.Write("Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            UserServices userServices = new UserServices();
            switch (choice)
            {
                case 1:
                    Login(userServices);
                    break;
                case 2:

                    SignUp(userServices);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        }
        public void ConnectToDataBase()
        {
            DataBaseServices databaseService = new DataBaseServices();
            try
            {
                databaseService.CreateUsersTable();
                databaseService.CreateProductsTable();
                databaseService.CreateProductBoughtTable();
                Console.WriteLine("Tables created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public void SignUp(UserServices userServices)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            string email2 = Console.ReadLine();
            int   phoneNumber;
            do
            {
                Console.WriteLine("Enter your phone number: ");
            } while (!int.TryParse(Console.ReadLine(), out  phoneNumber));
            Console.WriteLine("Are you an employee or a customer ");
            Console.WriteLine("1- Employee");
            Console.WriteLine("2- Customer");
            Console.Write("Your Choice: ");
            int choice2 = int.Parse(Console.ReadLine());

            if (choice2 == 1)
            {
                Console.WriteLine("Enter your position: ");
                string position = Console.ReadLine();
                Console.WriteLine("Enter your salary: ");
                float salary = float.Parse(Console.ReadLine());
                userServices.Registration(name, address, email2, phoneNumber.ToString(), position, salary.ToString());
            }
            else
            {
                Console.WriteLine("Enter your credit card: ");
                string creditCard = Console.ReadLine();
                userServices.Registration(name, address, email2, phoneNumber.ToString(), creditCard);
            }
        }
        public void Login(UserServices userServices)
        {
            /*          Console.Write("Enter your email: ");
         s             string email = Console.ReadLine();
                      Console.Write("Enter your password: ");
                      string password = Console.ReadLine();
                      userServices.Login(email, password);*/
        }
    }
}

using c__tutorial.Data_base;
using c__tutorial.Services;
using c__tutorial.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Store Program is the main class that will run the program 

namespace c__tutorial
{
    public class StoreProgram
    {
        public void Run()
        {


            // create a store object    
            Store store = new Store(1, "Play Teck");
            // create an owner object
            Employee owner = new Employee(1, "Ala", "Tunis", "ala@gmail.com", "123456789", Position.Owner, 10000);
            // set the owner of the store
            store.Owner = owner;
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(store);

            Product product = new Product(1, "Lenovo IPad 570", "I5 Gen10 8Go RAM ", 2500.0f);

            Product product2 = new Product(2, "MSI thin  GF 63", "I5 Gen12 24Go RAM ", 6500);

            Product product3 = new Product(3, "MAC  ", "M3 8 Go ", 2500.0f);

            Product product4 = new Product(4, "Hp omen desktop", "I7 Gen 12 16GO ", 70000.0f);

            store.AddProduct(product);

            store.AddProduct(product2);

            store.AddProduct(product3);

            store.AddProduct(product4);

            // the exit variable to exit the program
            bool exit = false;
            Console.WriteLine("Welcome to play Tech  sir how can  i help you");
            Shared.DisplayChoices();

            // loop to display the choices and get the user choice
            while (!exit)
            {
                int choice;
                // Handle the exception if the user entered a wrong choice like a letter or a symbol and 
                //ask him to enter a number
                try
                {
                    Console.WriteLine("Enter your choice");
                    Console.Write("Choice : ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("choice must be a number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        // display the products
                        Shared.DisplayProducts(store.Store_products);
                        break;
                    case 2:
                        // add a product to the store
                        store.AddProductWithConsole();
                        break;
                    case 3:
                        // remove a product from the store
                        Console.WriteLine("Enter the id of the product you want to remove");
                        int id = int.Parse(Console.ReadLine());
                        store.RemoveProduct(id);
                        break;
                    case 4:
                        // TODO
                        store.ExportProducts();
                        break;
                    case 5:
                        // exit the program
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;

                }
                if (exit)
                {
                    // exit the loop
                    break;
                }
                // ask the user if he wants to continue
                Console.WriteLine("do you want to continue ? y/n");
                string answer = Console.ReadLine();
                if (answer.Equals("y"))
                {
                    Shared.DisplayChoices();
                }
                else if (answer.Equals("n"))
                {
                    exit = true;
                }
                else
                {
                    // invalid choice if the user entered a wrong choice like 6 or 7 or any other number    
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class StoreProgram
    {
        public void Run()
        {
            Store store = new Store();

            store.id = 1;

            store.owner = "Ala";

            store.name = "Play tech";
            Product product = new Product(1, "Lenovo IPad 570", "I5 Gen10 8Go RAM ", 2500.0f);

            Product product2 = new Product(2, "MSI thin  GF 63", "I5 Gen12 24Go RAM ", 6500);

            Product product3 = new Product(3, "MAC  ", "M3 8 Go ", 2500.0f);

            Product product4 = new Product(4, "Hp omen desktop", "I7 Gen 12 16GO ", 70000.0f);

            store.addProduct(product);
            store.addProduct(product2);
            store.addProduct(product3);
            store.addProduct(product4);
            bool exit = false;
            Console.WriteLine("Welcome to play Tech  sir how can  i help you");
            Shared.DisplayChoices();


            while (!exit)
            {
                int choice = 0;
                try
                {
                    Console.WriteLine("Enter your choice");
                    Console.Write("Choice : ");
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("choice must be a number");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Shared.DisplayProducts(store.products);
                        break;
                    case 2:
                        store.addProductWithConsole();
                        break;
                    case 3:
                        Console.WriteLine("Enter the id of the product you want to remove");
                        int id = int.Parse(Console.ReadLine());
                        store.removeProduct(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter the id of the product you want to update");
                        int id2 = int.Parse(Console.ReadLine());
                        Product product5 = new Product();
                        product5.Id = id2;
                        store.updateProduct(product5);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        continue;

                }
                if (exit)
                {
                    break;
                }
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
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}

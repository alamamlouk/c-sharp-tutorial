using System;

namespace c__tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Please the select the program you want to run : ");
            int choice= int.Parse(Console.ReadLine());

            switch (choice) {  
                case 1:
               
                    StoreProgram storeProgram = new StoreProgram();
                    // run the store program
                    storeProgram.Run();
                    break;
                case 2:
                  
                    StoreProgramWithSQLite storeProgramWithSQLite = new StoreProgramWithSQLite();
                    storeProgramWithSQLite.Run();
                    break;
                case 3:
                    FindTheTreasure findTheTreasure = new FindTheTreasure();
                    findTheTreasure.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

  


        }
    }
}

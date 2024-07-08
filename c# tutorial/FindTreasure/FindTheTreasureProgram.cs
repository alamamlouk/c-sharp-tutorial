using c__tutorial.FindTreasure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial
{
    public class FindTheTreasure
    {
        public void Run()
        {
            Console.WriteLine("Which type of arrays you want to play in?");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    OneDimensionArray oneD = new OneDimensionArray(5);
                    oneD.InitializeMap();
                    int[] treasures = oneD.hideTheTreasure(2);
                    oneD.FindTheTreasure(treasures);
                    break;
                /*case 2:
                    TwoDimensionalArray();
                    break;
                case 3:
                    JaggedArray();
                    break;*/
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

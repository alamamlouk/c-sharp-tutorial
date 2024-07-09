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
            Console.WriteLine("1. One Dimension Array");
            Console.WriteLine("2. Two Dimension Array");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    OneDimensionArray oneD = new OneDimensionArray(5);
                    oneD.InitializeMap();
                    oneD.FindTheTreasure(oneD.HideTheTreasure<int[]>(2));
                    break;
                case 2:
                    TwoDimensionArray twoDimensionArray = new TwoDimensionArray(5);
                    twoDimensionArray.InitializeMap();
                    twoDimensionArray.FindTheTreasure(twoDimensionArray.HideTheTreasure<int[,]>(2));
                    break;
              
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

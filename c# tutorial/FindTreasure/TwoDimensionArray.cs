using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tutorial.FindTreasure
{
    public class TwoDimensionArray : ArrayDetails, IMap
    {
        public char[,] Map { get; set; }
        public TwoDimensionArray(int arraySize)
        {
            ArraySize = arraySize;
            Map = new char[ArraySize, ArraySize];
        }
        public void DisplayMap()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                for (int j = 0; j < ArraySize; j++)
                {
                    Console.Write("["+Map[i, j]+"]");
                }
                Console.WriteLine();
            }
        }

        public T HideTheTreasure<T>(int numberOfTreasure)
        {

            int[,] treasures = new int[numberOfTreasure, 2];
            Random random = new Random();
            int index_X;
            int index_Y;
            for (int i = 0; i < numberOfTreasure - 1; i++)
            {
                do
                {
                    index_X = random.Next(0, this.ArraySize-1);
                    index_Y = random.Next(0, this.ArraySize-1);
                } while (ContainsCoordinates(treasures, index_X, index_Y, i));
                treasures[i, 0] = index_X;
                treasures[i, 1] = index_Y;

            }

            return (T)(Object)treasures;
        }
        private bool ContainsCoordinates(int[,] treasures, int x, int y, int filledCount)
        {
            for (int i = 0; i < filledCount; i++)
            {
                if (treasures[i, 0] == x && treasures[i, 1] == y)
                {
                    return true;
                }
            }
            return false;
        }

        public void FindTheTreasure<T>(T HiddenTreasures) {
            DisplayMap();
            int[,] treasures= (int[,])(Object)HiddenTreasures;
            int NoMoreTreasure = treasures.Length/2;

            do
            {

                Console.WriteLine("Enter the X index to find the treasure:");
                int indexX = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y index to find the treasure:");
                int indexY = int.Parse(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < treasures.GetLength(0); i++)
                {
                    if (treasures[i, 0] == indexX && treasures[i, 1] == indexY)
                    {
                        Map[indexX, indexY] = 'X'; 
                        Console.WriteLine("You found the treasure!");
                        treasures[i, 0] = -1; 
                        treasures[i, 1] = -1; 
                        NoMoreTreasure--;
                        Console.WriteLine("You have " + NoMoreTreasure + " more treasure(s) to find.");
                        DisplayMap();
                        found = true;
                        break;
                    }
                   
                }
                if(!found)
                {
                    Console.WriteLine("You missed the treasure, try again");
                }
            } while (NoMoreTreasure > 0);
        }

        public void InitializeMap()
        {
            for (int i = 0; i < this.ArraySize; i++)
            {
                for (int j = 0; j < this.ArraySize; j++)
                {
                    Map[i, j] = 'O';
                }

            }

        }

        
    }
}

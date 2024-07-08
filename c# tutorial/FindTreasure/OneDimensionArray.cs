using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace c__tutorial.FindTreasure
{
    public class OneDimensionArray : ArrayDetails, IMap
    {
        
        public char[] Map { get; set; }
        public OneDimensionArray(int ArraySize)
        {
            this.ArraySize = ArraySize;
            Map = new char[ArraySize];
        }
        public T HideTheTreasure<T>(int numberOfTreasure)
        {
            int[] treasures = new int[numberOfTreasure];
            Random random = new Random();
            int index;
            for (int i = 0; i < numberOfTreasure - 1; i++)
            {
                do
                {
                    index = random.Next(0, this.ArraySize);

                } while (treasures.Contains(index));
                treasures[i] = index;

            }

            return (T)(object)treasures;
        }
        public void FindTheTreasure<T>(T HiddenTreasures)
        {
            DisplayMap();
            int[] treasures = (int[])(object)HiddenTreasures;
            int NoMoreTreasure = treasures.Length;
            do
            {

                Console.WriteLine("Enter the index to find the treasure");
                int index = int.Parse(Console.ReadLine());
                int foundIndex = Array.IndexOf(treasures, index);

                if (foundIndex != -1)
                {
                    Map[index] = 'X';
                    Console.WriteLine("You found the treasure");
                    HiddenTreasures = (T)(object)treasures.Where((val, idx) => idx != foundIndex).ToArray();
                    NoMoreTreasure--;
                    Console.WriteLine("You have " + NoMoreTreasure + " more treasure to find");
                    DisplayMap();

                }
                else
                {
                    Console.WriteLine("You missed the treasure, try again");
                }
            } while (NoMoreTreasure > 0);
        }
        public void InitializeMap()
        {
            for (int i = 0; i < this.ArraySize; i++)
            {
                Map[i] = 'O';
            }
        }

        public void DisplayMap()
        {
            for (int i = 0; i < Map.Length; i++)
            {
                Console.Write("[" + Map[i] + "],");
            }
        }

       
    }
}

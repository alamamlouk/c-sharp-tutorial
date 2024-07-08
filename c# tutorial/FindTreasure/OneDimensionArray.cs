using System;
using System.Linq;

namespace c__tutorial.FindTreasure
{
    public class OneDimensionArray
    {
        private int ArraySize { get; set; }
        private char[] Map { get; set; }
        public OneDimensionArray(int size)
        {
            this.ArraySize = size;
            this.Map = new char[size];
        }
        public int[] hideTheTreasure(int numberOfTreasure)
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

            return treasures;
        }
        public void FindTheTreasure(int[] HiddenTreasures)
        {
            DisplayMap(Map);
            int NoMoreTreasure = HiddenTreasures.Length;

            do
            {

                Console.WriteLine("Enter the index to find the treasure");
                int index = int.Parse(Console.ReadLine());
                if (HiddenTreasures.Contains(index))
                {
                    Map[index] = 'X';
                    Console.WriteLine("You found the treasure");
                    HiddenTreasures = HiddenTreasures.Where(val => val != index).ToArray();
                    NoMoreTreasure--;
                    Console.WriteLine("You have " + NoMoreTreasure + " more treasure to find");
                    DisplayMap(Map);

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
        public void DisplayMap(char[] TheMap)
        {
            for (int i = 0; i < TheMap.Length; i++)
            {
                Console.Write("[" + TheMap[i] + "],");
            }

        }
    }
}

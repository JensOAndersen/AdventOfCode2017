using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DayFive
{
    public class DayFiveSolution
    {
        public static int[] input = TBox.GetIntsFromFile(@"C:\Users\Seth_Laptop\Documents\Visual Studio 2017\Projects\AdventOfCode2017\DayFive\Input.txt");

        public static int SolutionPartOne()
        {
            int steps = 0;
            int nextNumber = input[0];
            while (nextNumber >= 0 && nextNumber < input.Length)
            {
                nextNumber = input[nextNumber];

                int temp = input[nextNumber];

                if (temp >= 0 && temp < input.Length)
                {
                    input[temp] += 1;

                }

                steps++; //number of steps taken
            }
            return steps;
        }
    }
}

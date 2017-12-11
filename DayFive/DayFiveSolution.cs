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
        public static int[] input = TBox.GetIntsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayFive\Input.txt");

        public static int SolutionPartOne()
        {
            int steps = 0;
            int nextNumber = input[0];
            int previousNumber = input[0];

            while (nextNumber >= 0 && nextNumber < input.Length)
            {
                previousNumber = nextNumber;
                nextNumber += input[nextNumber];

                if(nextNumber >= 0 && nextNumber < input.Length)
                {
                    if(input[previousNumber] >= 3)
                    {
                        input[previousNumber] -= 1;
                    } else
                    {
                        input[previousNumber] += 1;
                    }
                }

                steps++; //number of steps taken
            }
            return steps;
        }
    }
}

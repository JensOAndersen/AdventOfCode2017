using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DayTwo
{
    public class DayTwoSolution
    {
        static string path = @"c:\users\seth_laptop\documents\visual studio 2017\Projects\AdventOfCode2017\DayTwo\Input.txt";
        public static int GetCorruptionChecksum()
        {
            int[,] values = TBox.Get2DArrayOfInts(path, '\t');

            int sum = 0;

            for (int i = 0; i < values.GetLength(0); i++)
            {
                int lowest = values[i, 0];
                int highest = lowest;
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    if (lowest > values[i, j]) lowest = values[i, j];
                    if (highest < values[i, j]) highest = values[i, j];
                }
                sum += highest - lowest;
            }

            return sum;
        }

        public static int GetCorruptionCheckSumDiv()
        {
            int[,] values = TBox.Get2DArrayOfInts(path, '\t');

            int sum = 0;

            for (int i = 0; i < values.GetLength(0); i++)
            {
                int firstComparer = values[i, 0];
                for (int j = 0; j < values.GetLength(1); j++)
                {
                    firstComparer = values[i, j];
                    int secondComparer = values[i, j];
                    for (int l = 0; l < values.GetLength(1); l++)
                    {
                        secondComparer = values[i, l];
                        if((firstComparer != secondComparer) && firstComparer % secondComparer == 0)
                        {
                            sum += firstComparer / secondComparer;
                        }
                    }
                }
            }

            return sum;
        }
    }
}

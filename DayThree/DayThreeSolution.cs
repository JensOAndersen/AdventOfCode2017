using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;

namespace DayThree
{
    public class DayThreeSolution
    {
        public static int size = 10;
        private static int[,] intarr = new int[size, size];

        public static int SolutionOne()
        {
            int[,] intarr = new int[20, 20];
            int x = 0;
            int y = 0;
            int length = 0; //length of the "stride" in the 2d-array
            int counter = 1;
            int goal = 361527;
            while (counter != goal)
            {
                for (int leftRight = 0; leftRight < length; leftRight++)
                {
                    if (counter != goal)
                    {
                        counter++;
                        if (length % 2 == 0)
                        {
                            x++;
                        }
                        else
                        {
                            x--;
                        }
                    }
                }
                for (int upDown = 0; upDown < length; upDown++)
                {
                    if (counter != goal)
                    {
                        counter++;
                        if (length % 2 == 0)
                        {
                            y++;
                        }
                        else
                        {
                            y--;
                        }
                    }
                }
                length++;
            }
            return Math.Abs(x) + Math.Abs(y);
        }
        private static int AddSorroundings(int x, int y)
        {
            int sum = 0;
            sum += intarr[x - 1, y - 1];
            sum += intarr[x, y - 1];
            sum += intarr[x + 1, y - 1];

            sum += intarr[x - 1, y + 1];
            sum += intarr[x, y + 1];
            sum += intarr[x + 1, y + 1];

            sum += intarr[x-1, y];
            sum += intarr[x+1, y];
            if(sum == 0)
            {
                return 1;
            }
            return sum;
        }
        public static int[,] SolutionTwo()
        {
            int x = size/2;
            int y = size/2;
            int length = 0; //length of the "stride" in the 2d-array
            int counter = 1;
            int goal = 361527;

            intarr[x, y] = 1;

            while (counter < goal)
            {
                for (int leftRight = 0; leftRight < length; leftRight++)
                {
                    if (counter < goal)
                    {
                        counter = DayThreeSolution.AddSorroundings(x, y);
                        intarr[x, y] = counter;
                        
                        if (length % 2 == 0)
                        {
                            x++;
                        }
                        else
                        {
                            x--;
                        }
                    }
                }
                for (int upDown = 0; upDown < length; upDown++)
                {
                    if (counter < goal)
                    {
                        counter = DayThreeSolution.AddSorroundings(x, y);
                        intarr[x, y] = counter;

                        if (length % 2 == 0)
                        {
                            y++;
                        }
                        else
                        {
                            y--;
                        }
                    }
                }
                length++;
            }
            return intarr;
        }
    }
}

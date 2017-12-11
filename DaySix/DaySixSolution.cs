using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DaySix
{
    public class DaySixSolution
    {
        public static int[,] input2D = TBox.Get2DArrayOfInts(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DaySix\input.txt",'\t');

        public static int DaySixPartTwo()
        {
            bool hasFoundOnce = false;
            int[] input = new int[input2D.Length]; //my input array
            #region 2Dto1D
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input2D[0, i];
            }
            #endregion

            List<string> oldDistributions = new List<string>();
            int jumps = 0;

            //set up the method, and the original string
            string oString = "";

            foreach (int i in input)
            {
                oString += i.ToString()+ ",";
            }
            oldDistributions.Add(oString);

            //main loop redistributing numbers
            do
            {
                string cString = "";
                //do the main logic, find the largest number and redistribute
                int hIndex = 0;
                int hNumber = input[0];
                //find highest number and index thereof
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > hNumber)
                    {
                        hIndex = i;
                        hNumber = input[i];
                    }
                }

                input[hIndex] = 0; //set the highest number index to 0;

                //redistribute
                for (int i = hNumber; i > 0; i--)
                {
                    input[(hIndex + 1) % input.Length] += 1;
                    hIndex++;
                }

                //make a new comparestring and add it to the list
                foreach (int i in input)
                {
                    cString += i.ToString() + ",";
                }
                if (!oldDistributions.Contains(cString))
                {
                    oldDistributions.Add(cString);
                } else
                {
                    if (!hasFoundOnce)
                    {
                        oString = cString;
                        hasFoundOnce = true;
                        jumps = 0;

                    } else if(oString == cString)
                    {
                        break;
                    }
                }
                jumps++;
            } while (true);


            return jumps;
        }   

        public static int DaySixPartOne()
        {
            int[] input = new int[input2D.Length]; //my input array
            #region 2Dto1D
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input2D[0, i];
            }
            #endregion

            List<string> oldDistributions = new List<string>();
            int jumps = 0;

            //set up the method, and the original string
            string oString = "";

            foreach (int i in input)
            {
                oString += i.ToString() + ",";
            }
            oldDistributions.Add(oString);

            //main loop redistributing numbers
            do
            {
                string cString = "";
                //do the main logic, find the largest number and redistribute
                int hIndex = 0;
                int hNumber = input[0];
                //find highest number and index thereof
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] > hNumber)
                    {
                        hIndex = i;
                        hNumber = input[i];
                    }
                }

                input[hIndex] = 0; //set the highest number index to 0;

                //redistribute
                for (int i = hNumber; i > 0; i--)
                {
                    input[(hIndex + 1) % input.Length] += 1;
                    hIndex++;
                }

                //make a new comparestring and add it to the list
                foreach (int i in input)
                {
                    cString += i.ToString() + ",";
                }
                if (!oldDistributions.Contains(cString))
                {
                    oldDistributions.Add(cString);
                }
                else
                {
                    break;
                }
                jumps++;
            } while (true);


            return jumps + 1;
        }
    }
}

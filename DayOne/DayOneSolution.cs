using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DayOne
{
    public class DayOneSolution
    {
        private static string input = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayOne\Input.txt")[0];

        /// <summary>
        /// Solves the first part of the day one puzzle
        /// </summary>
        /// <returns></returns>
        public static int GetCaptcha()
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                //check if the next value is outside the index of the array,
                //if outside 
                if(i+1 == input.Length)
                {
                    if (input[i] == input[0])
                        sum += int.Parse(input[i].ToString());
                }
                else if (input[i] == input[i+1])
                {
                    sum += int.Parse(input[i].ToString());
                }
            }

            return sum;
        }


        /// <summary>
        /// Solves the second part of the day one puzzle
        /// </summary>
        /// <returns></returns>
        public static int GetCaptchaHalf()
        {
            int debone = input.Length;
            int debTwo = input.Length / 2;

            int sum = 0;
            for (int i = 0; i < input.Length/2; i++)
            {
                if(input[i] == input[(input.Length / 2)+i])
                {
                    sum += int.Parse(input[i].ToString())*2;
                }
            }

            return sum;
        }
    }
}

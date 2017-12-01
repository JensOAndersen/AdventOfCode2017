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

        public static int GetCaptcha()
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DayNine
{
    public class DayNineSolution
    {
        private static string input = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayNine\Input.txt")[0];

        public static int PartOne()
        {
            string firstPass = "";

            //remove ignored characters;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '!')
                {
                    i++;
                } else
                {
                    firstPass += input[i];
                }
            }

            bool isGarbage = false;
            string garbageString = "";

            for (int i = 0; i < firstPass.Length; i++)
            {
                if(firstPass[i] == '<' && !isGarbage)
                {
                    isGarbage = true;
                    i++;
                }
                if (isGarbage && firstPass[i] != '>')
                {
                    garbageString += firstPass[i];
                }
                if (firstPass[i] == '>')
                {
                    isGarbage = false;
                }
            }

            int garbagecount = 0;
            foreach (char c in garbageString)
            {
                garbagecount++;
            }

            return garbagecount;
        }
    }
}

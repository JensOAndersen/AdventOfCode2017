using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;

namespace DayFour
{
    public class DayFourSolution
    {
        static string[] result = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayFour\Input.txt");
        public static int ValidPasswordsPartOne()
        {
            int uniqueCount = 0;
            foreach (string s in result)
            {
                string[] temp = s.Split(' ');

                bool isUnique = true;
                for (int i = 0; i < temp.Length; i++)
                {
                    string firstComparer = temp[i];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if(firstComparer == temp[j] && j != i)
                        {
                            isUnique = false;
                        }
                    }
                }
                if (isUnique)
                {
                    uniqueCount++;
                }
            }
            return uniqueCount;
        }
        public static int ValidPasswordsPartTwo()
        {
            int uniqueCount = 0;
            foreach (string s in result)
            {
                string[] temp = s.Split(' ');

                bool isUnique = true;
                for (int i = 0; i < temp.Length; i++)
                {
                    string firstComparer = temp[i];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        string secondComparer = temp[j];

                        isUnique = !IsAnagram(firstComparer, secondComparer);
                    }
                }
                if (isUnique)
                {
                    uniqueCount++;
                }
            }
            return uniqueCount;
        }

        static bool IsAnagram(string first, string second)
        {
            bool isA = true;
            foreach (char s in first)
            {
                for (int i = second.Length-1; i > 0; i--)
                {
                    if (s != second[i]) isA = false;
                }
            }

            return isA;
        }
    }
}

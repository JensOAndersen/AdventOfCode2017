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
        static string[] result = TBox.GetStringsFromFile(@"C:\Users\Seth_Laptop\Documents\Visual Studio 2017\Projects\AdventOfCode2017\DayFour\Input.txt");
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
                string[] words = s.Split(' ');
                bool isNotValid = true;

                for (int i = 0; i < words.Length; i++)
                {

                    char[] firstComparer = words[i].ToCharArray();
                    Array.Sort(firstComparer);
                    string firstWord = new string(firstComparer);

                    for (int j = 0; j < words.Length; j++)
                    {

                        char[] secondComparer = words[j].ToCharArray();
                        Array.Sort(secondComparer);
                        string secondWord = new string(secondComparer);

                        if (i != j && firstWord == secondWord && isNotValid)
                        {
                            isNotValid = false;
                            uniqueCount++;
                        }
                    }
                    
                }
            }
            return uniqueCount;
        }
    }
}

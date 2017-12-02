using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toolbox
{
    public class TBox
    {
        public static string[] GetStringsFromFile(string path)
        {
            List<string> returnList = new List<string>();

            using(StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    returnList.Add(reader.ReadLine());
                }
            }
            return returnList.ToArray();
        }

        public static int[] GetIntsFromFile(string path)
        {
            string[] stringArr = GetStringsFromFile(path);
            int[] returnArr = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                returnArr[i] = int.Parse(stringArr[i]);
            }

            return returnArr;
        }

        public static int[,] Get2DArrayOfInts(string path, char seperator)
        {
            char sep = seperator;
            string[] arr = GetStringsFromFile(path);
            List<int[]> intList = new List<int[]>();
            
            foreach (string s in arr)
            {
                string[] temp = s.Split(sep);

                int[] line = new int[temp.Length];

                for (int i = 0; i < temp.Length; i++)
                {
                    line[i] = int.Parse(temp[i]);
                }

                intList.Add(line);
            }

            int[,] returnArr = new int[intList.Count, intList[0].Length];

            for (int i = 0; i < returnArr.GetLength(0); i++)
            {
                for (int j = 0; j < returnArr.GetLength(1); j++)
                {
                    returnArr[i, j] = intList[i][j];
                }
            }

            return returnArr;
        }
    }
}

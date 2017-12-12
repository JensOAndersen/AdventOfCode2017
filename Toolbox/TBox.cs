using System;
using System.Collections.Generic;
using System.IO;

namespace Toolbox
{
    public class TBox
    {
        /// <summary>
        /// Gets an array of strings, every line in the input is a index in the array
        /// </summary>
        /// <param name="path">path to the file</param>
        /// <returns>[] of strings</returns>
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
        /// <summary>
        /// Returns an array of ints, every line in the input is a int.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns an array of ints where all ints are on the same line of the input
        /// </summary>
        /// <param name="path">Path of the input file</param>
        /// <param name="seperator">The seperator char</param>
        /// <returns></returns>
        public static int[] GetIntsFromFile(string path, char seperator)
        {
            string[] input = GetStringsFromFile(path)[0].Split(seperator);

            int[] returnArr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int.TryParse(input[i], out int outInt);
                returnArr[i] = outInt;
            }

            return returnArr;
        }  
        /// <summary>
        /// Returns a 2D array of ints
        /// </summary>
        /// <param name="path">path</param>
        /// <param name="seperator">Is the seperator in the second dimension of the array</param>
        /// <returns></returns>
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

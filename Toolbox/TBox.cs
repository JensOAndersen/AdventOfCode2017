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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;

namespace DayTen
{
    public class DayTenSolution
    {
        private static int[] input = TBox.GetIntsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayTen\Input.txt", ',');

        public static int PartOne()
        {
            //populate and make array
            List<int> intList = new List<int>();

            for (int i = 0; i < 256; i++)
            {
                intList.Add(i);
            }

            int skipSize = 0;
            int position = 0;

            //loop through each "instruction"
            foreach (int length in input)
            {
                //get a part of the array to be reversed
                List<int> reverseSection = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    reverseSection.Add(intList[(position + i) % intList.Count]);
                }
                reverseSection.Reverse(); //reverse the part

                //reinsert the section
                for (int i = 0; i < reverseSection.Count; i++)
                {
                    intList[(position + i) % intList.Count] = reverseSection[i];
                }

                //set a new position
                position = (position + skipSize + length)%intList.Count;

                skipSize++;
            }

            return intList[0] * intList[1];
        }

        private static string strInput = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayTen\Input.txt")[0];

        public static string PartTwo()
        {
            strInput = strInput.Trim();
            Encoding ascii = Encoding.ASCII;

            //populate and make array
            List<int> intList = new List<int>();
            for (int i = 0; i < 256; i++)
            {
                intList.Add(i);
            }
            
            List<int> lengths = new List<int>();
            List<int> additionalLengths = new List<int>() { 17, 31, 73, 47, 23 }; //additional lenghts, to be added
            foreach (char c in strInput)
            {
                lengths.Add(ascii.GetBytes(c.ToString()).First()); //convert the input string to ascii chars
            }

            lengths.AddRange(additionalLengths); //add the added length

            int skipSize = 0;
            int position = 0;

            //loop through each "instruction", and repeat 64 times
            for (int l = 0; l < 64; l++)
            {
                foreach (var c in lengths)
                {
                    //get a part of the array to be reversed
                    List<int> reverseSection = new List<int>();
                    for (int j = 0; j < c; j++)
                    {
                        reverseSection.Add(intList[(position + j) % intList.Count]);
                    }
                    reverseSection.Reverse(); //reverse the part

                    //reinsert the section
                    for (int i = 0; i < reverseSection.Count; i++)
                    {
                        intList[(position + i) % intList.Count] = reverseSection[i];
                    }
                    //set a new position
                    position = (position + skipSize + c) % intList.Count;

                    skipSize++;
                }
            }

            //convert the inlist to 16 blocks of values
            List<int> xorBlocks = new List<int>();
            int blockSize = 16;
            int index = 0;
            for (int i = 0; i < blockSize; i++)
            {
                int tempBlock = 0;
                for (int j = 0; j < blockSize; j++)
                {
                    tempBlock = tempBlock ^ intList[index];
                    index++;
                }
                xorBlocks.Add(tempBlock);
            }

            //convert them to hexadecimal values
            List<string> hexadecimalValues = new List<string>();
            foreach (int i in xorBlocks)
            {
                hexadecimalValues.Add(i.ToString("X2"));
            }


            return string.Join("", hexadecimalValues).ToLower();
        }
    }
}

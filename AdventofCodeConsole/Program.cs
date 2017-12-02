using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOne;
using DayTwo;
namespace AdventofCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day 1, part 1 - Works!
            //Console.WriteLine(DayOneSolution.GetCaptcha());

            //Day 1, part 2 - Works!
            //Console.WriteLine(DayOneSolution.GetCaptchaHalf());

            //Day 2, part 1 - Works!;
            //Console.WriteLine(DayTwoSolution.GetCorruptionChecksum());

            //Day 2, part 2 - Works!
            Console.WriteLine(DayTwoSolution.GetCorruptionCheckSumDiv());

            Console.ReadKey(); //stop the program from exiting
        }
    }
}

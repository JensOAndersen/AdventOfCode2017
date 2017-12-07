using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOne;
using DayTwo;
using DayThree;
using DayFour;
using DayFive;
namespace AdventofCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region old

            //Day 1, part 1 - Works!
            //Console.WriteLine(DayOneSolution.GetCaptcha());

            //Day 1, part 2 - Works!
            //Console.WriteLine(DayOneSolution.GetCaptchaHalf());

            //Day 2, part 1 - Works!;
            //Console.WriteLine(DayTwoSolution.GetCorruptionChecksum());

            //Day 2, part 2 - Works!
            //Console.WriteLine(DayTwoSolution.GetCorruptionCheckSumDiv());

            //Day 3, Part 1 - Works!
            //Console.WriteLine( DayThreeSolution.SolutionOne() );

            //Day 3, Part 2 - Works!
            //int[,] sol = DayThreeSolution.SolutionTwo();
            //for (int i = 0; i < sol.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sol.GetLength(1); j++)
            //    {
            //        Console.Write(sol[j, i].ToString().PadLeft(10));
            //    }
            //    Console.WriteLine();
            //}

            //Day 4, Part 1 - Works!
            //Console.WriteLine(DayFourSolution.ValidPasswordsPartOne());

            //Day 4, Part 2 - Works!
            //Console.WriteLine(DayFourSolution.ValidPasswordsPartTwo());
            #endregion

            //Day 5, part 1 - WIP
            Console.WriteLine(DayFiveSolution.SolutionPartOne());

            Console.ReadKey(); //stop the program from exiting
        }
    }
}

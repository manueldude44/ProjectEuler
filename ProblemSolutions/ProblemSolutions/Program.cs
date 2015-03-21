using System;
using System.Collections.Generic;
using ProblemSolutions.Interfaces;
using ProblemSolutions.Problems;

namespace ProblemSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Start ===");
            var problems = new List<IAnswer>
            {
                new Problem1(),
                new Problem2(),
                new Problem3(),
                new Problem4(),
                new Problem5(),
                new Problem6()
            };

            foreach (var problem in problems)
            {
                try
                {
                    problem.Solve();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error Occured. " + e.Message);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }
    }
}

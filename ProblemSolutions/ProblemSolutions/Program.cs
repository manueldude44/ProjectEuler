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
                new Problem2()
            };

            foreach (var problem in problems)
            {
                problem.Solve();
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to continue");
            Console.ReadLine();
        }
    }
}

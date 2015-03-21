using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem6 : BasicOutLog, IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 6"; }
        }

        public override string Answer { get; set; }

        public void Solve()
        {
            long answer = 0;
            var squareSum = 0;
            var sumSquare = 0;
            var max = 100;
            for (int i = 0; i <= max; i++)
            {
                sumSquare += i;
            }
            sumSquare *= sumSquare;

            for (int i = 0; i <= max; i++)
            {
                squareSum += i*i;
            }

            answer = sumSquare - squareSum;
            Answer = answer.ToString();
            PrintAnswer();
        }
    }
}

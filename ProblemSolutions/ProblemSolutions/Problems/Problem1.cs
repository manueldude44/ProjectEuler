using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions.Problems
{
    public class Problem1 : BasicOutLog
    {
        public Problem1()
        {
            ProblemNumber = "Problem 1";
        }
        
        public void Solve()
        {
            long answer = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0) answer += i;
            }

            Answer = answer.ToString();
            PrintAnswer();
        }
    }
}

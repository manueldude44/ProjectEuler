using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem4 : BasicOutLog, IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 4"; }
        }

        public override string Answer { get; set; }

        public void Solve()
        {
            long min = 111;
            long max = 999;
            long palindrome = 0;
            for (long i = min; i <= max; i++)
            {
                for (long j = min; j <= max; j++)
                {
                    var c = i*j;
                    var s = c.ToString();
                    var isPalindrome = true;
                    for (int k = 0; k <= s.Length/2; k++)
                    {
                        if (s[k] == s[s.Length - 1 - k]) continue;
                        isPalindrome = false;
                    }
                    if (!isPalindrome) continue;
                    if (c > palindrome) palindrome = c;
                }
            }
            Answer = palindrome.ToString();
            PrintAnswer();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem3: BasicOutLog ,IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 3"; }
        }

        public override string Answer { get; set; }

        public void Solve()
        {
            long answer = 0;
            long upper = 600851475143;
            long max = upper;
            var upperPrimeNumbers = new List<long>();
            for (long i = 0; i <= max; i++)
            {
                if (i <= 1) continue;
                var isPrime = true;
                foreach (var primeNumber in upperPrimeNumbers)
                {
                    if (i%primeNumber != 0) continue;
                    isPrime = false;
                }
                if (!isPrime) continue;
                if (upper%i != 0) continue;
                upperPrimeNumbers.Add(i);
                max /= i;
            }
            
            Answer = upperPrimeNumbers.Last().ToString();
            PrintAnswer();
        }
    }
}

using System.Diagnostics.SymbolStore;
using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem5 : BasicOutLog, IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 5"; }
        }

        public override string Answer { get; set; }

        public void Solve()
        {
            long answer = 0;
            long count = 20;
            while (answer == 0)
            {
                var isAnswer = true;
                for (int i = 2; i <= 20; i++)
                {
                    if (count%i == 0) continue;
                    isAnswer = false;
                    break;
                }
                if (isAnswer)
                {
                    answer = count;
                    break;
                }
                count++;
            }

            Answer = answer.ToString();
            PrintAnswer();
        }
    }
}

using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem1 : BasicOutLog, IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 1"; }
        }

        public override string Answer { get; set; }
        
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

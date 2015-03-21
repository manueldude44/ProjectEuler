using ProblemSolutions.Abstracts;
using ProblemSolutions.Interfaces;

namespace ProblemSolutions.Problems
{
    public class Problem2 : BasicOutLog, IAnswer
    {
        public override string ProblemNumber
        {
            get { return "Problem 2"; }
        }

        public override string Answer { get; set; }

        public void Solve()
        {
            var a = 0;
            var b = 1;
            var c = 0;
            var answer = 0;
            while (c <= 4000000 )
            {
                if (c%2 == 0) answer += c;
                c = a + b;
                a = b;
                b = c;
            }
            Answer = answer.ToString();
            PrintAnswer();
        }
    }
}

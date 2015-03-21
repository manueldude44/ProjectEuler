using System;

namespace ProblemSolutions.Abstracts
{
    public abstract class BasicOutLog
    {
        public abstract string ProblemNumber { get; }
        public abstract string Answer { get; set; }

        public void PrintAnswer()
        {
            var s = String.Format("Answer for {0} is: {1}", ProblemNumber, Answer);
            Console.WriteLine(s);
        }
    }
}

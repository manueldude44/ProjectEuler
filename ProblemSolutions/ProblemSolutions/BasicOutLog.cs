using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolutions
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

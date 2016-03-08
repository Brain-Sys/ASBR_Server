using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASBR_Server
{
    class ProblemSolver : IProblemSolver
    {
        public int AddNumbers(int a, int b)
        {
            string message = string.Format("Sum requested : {0} + {1}", a, b);
            string timestamp = DateTime.Now.ToString();
            string output = string.Concat(timestamp, ", ", message);
            Console.WriteLine(output);
            return a + b;
        }
    }
}
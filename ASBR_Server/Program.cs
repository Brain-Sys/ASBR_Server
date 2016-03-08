using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ASBR_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var sh = new ServiceHost(typeof(ProblemSolver));
            sh.Open();
            Console.WriteLine("Server started!!!");
            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();
            sh.Close();
        }
    }
}
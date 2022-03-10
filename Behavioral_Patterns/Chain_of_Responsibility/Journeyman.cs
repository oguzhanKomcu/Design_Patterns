using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Journeyman : ProblemSolverEmployeeBase
    {
        public override void ProblemSolving(Problem problem)
        {
            if (problem == Problem.Care)
            {
                Console.WriteLine("The journeyman can solve this problem....!");
            }
            else if (_successor != null)
            {
                _successor.ProblemSolving(problem);
            }
        }
    }
}

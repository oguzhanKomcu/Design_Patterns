using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Apprentice : ProblemSolverEmployeeBase
    {
        public override void ProblemSolving(Problem problem)
        {

            if (problem == Problem.Care)
            {
                Console.WriteLine("Apprentice can do maintenance work...!");
            }
            else if (_successor != null)
            {
                _successor.ProblemSolving(problem);
            }
        }
    }
}

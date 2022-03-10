using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public  class Master :ProblemSolverEmployeeBase
    {
        public override void ProblemSolving(Problem problem)
        {
            if (problem == Problem.Repair)
            {
                Console.WriteLine("Master can find this problem.....!");
            }
            
        }
    }
}

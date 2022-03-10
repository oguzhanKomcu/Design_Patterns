using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{

    //Handler 
    //Here is my class to create my chain.
    public abstract class ProblemSolverEmployeeBase
    {
        protected ProblemSolverEmployeeBase _successor;

        public void SetSuccessor(ProblemSolverEmployeeBase employeeBase)
        {
            this._successor = employeeBase;
        }

        public abstract void ProblemSolving(Problem problem);

    }
}

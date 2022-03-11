using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Design_Pattern
{
    public  class InvokerFileOperations
    {

        //Here I make my methods an object and trigger it via another class "Inkover".

        private Stack<ICommand> commandList = new Stack<ICommand>();

        public void ExecuteAll()
        {
            while (commandList.Count > 0)
            {
                commandList.Pop().Execute();
            }
        }

        public void AddCommand(ICommand c)
        {
            commandList.Push(c);
        }
    }
}

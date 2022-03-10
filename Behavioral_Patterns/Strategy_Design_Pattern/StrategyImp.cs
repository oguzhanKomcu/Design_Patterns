using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    public class StrategyImp
    {
        IStrategy strategy;

        public StrategyImp(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int OperationImp(int num1, int num2)
        {
            return strategy.Opreation(num1, num2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {



            StrategyImp collection = new StrategyImp(new Collection());
            Console.WriteLine($"Collection ={collection.OperationImp(24,56)} ");

            StrategyImp extraction = new StrategyImp(new Extraction());
            Console.WriteLine($"Extraction ={extraction.OperationImp(78, 32)} ");

            StrategyImp ımpact = new StrategyImp(new Impact());
            Console.WriteLine($"ımpact ={ımpact.OperationImp(20, 13)} ");

            StrategyImp divide = new StrategyImp(new Divide());
            Console.WriteLine($"Divide ={divide.OperationImp(80, 3)} ");

            Console.ReadKey();
        }
    }
}

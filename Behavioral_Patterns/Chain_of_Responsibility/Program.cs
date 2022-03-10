using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Allows us to design an approval flow in an effective and loosely coupled way


            Master master = new Master();   
            Journeyman journeyman = new Journeyman();
            Apprentice apprentice = new Apprentice();   

            apprentice.SetSuccessor(journeyman);
            journeyman.SetSuccessor(master);

            apprentice.ProblemSolving(Problem.Repair);
            Console.ReadKey();



        }
    }
}

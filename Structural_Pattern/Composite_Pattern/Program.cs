using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Finally, I run and call my objects in my system sequentially.
            //Actually, we can compare it to this.
            //File/My Personal Files/Photo and Video/My Photos
            //It is similar to the category logic in an e-commerce application.
            //categories/tv,image and sound systems/television/brand/model

            Official ceo = new Official("Oğuzhan", Position.CEO);


            Official team_manager = new Official("Elif",Position.Team_Manager);
            team_manager.AddEmployee(new SUB_AUTHORITY("Gamze",Position.Development));
            team_manager.AddEmployee(new SUB_AUTHORITY("Levent", Position.Development));

            Official hr_director = new Official("Büşra", Position.HR_Director);
            hr_director.AddEmployee(new SUB_AUTHORITY("Okan", Position.Marketing));
            hr_director.AddEmployee(new SUB_AUTHORITY("Sedef", Position.Architect));

            ceo.AddEmployee(team_manager);
            ceo.AddEmployee(hr_director);

           

            ceo.SendMessage();
            Console.ReadLine();
        }
    }
}

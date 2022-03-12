using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWhatsappGroupMediator WhatsappGroup = new ConcreteMediator();
            User Batuhan = new ConcreteUser(WhatsappGroup, "Batuhan");
            User Sezer = new ConcreteUser(WhatsappGroup, "Sezer");
            User Furkan = new ConcreteUser(WhatsappGroup, "Furkan");
            User Anıl = new ConcreteUser(WhatsappGroup, "Anıl");
            User Oguzhan = new ConcreteUser(WhatsappGroup, "Oguzhan");

            WhatsappGroup.RegisterUser(Batuhan);
            WhatsappGroup.RegisterUser(Sezer);
            WhatsappGroup.RegisterUser(Furkan);
            WhatsappGroup.RegisterUser(Anıl);
            WhatsappGroup.RegisterUser(Oguzhan);


            Oguzhan.Send("Hey guys. Shall we meet tonight?");
            Console.WriteLine();

            Furkan.Send("I have to study tonight, I'm sorry I can't come.");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Design_Pattern
{
    public abstract class User
    {
        protected IWhatsappGroupMediator mediator;
        protected string name;
        public User(IWhatsappGroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        public abstract void Send(string message);
        public abstract void Receive(string message);



    }
}

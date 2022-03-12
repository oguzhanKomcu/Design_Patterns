using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Design_Pattern
{
    public interface IWhatsappGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}

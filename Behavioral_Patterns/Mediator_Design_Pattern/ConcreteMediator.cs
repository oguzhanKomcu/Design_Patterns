using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Design_Pattern
{
    public class ConcreteMediator : IWhatsappGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }
        public void SendMessage(string message, User user)
        {
            foreach (var member in usersList)
            {
         
                if (member != user)
                {
                    member.Receive(message);
                }
            }
        }
    }
}

using Prototype_Pattern1.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern1.Model
{
    public class Student : IPrototypeStudent
    {
        public Student(string first_Name, string last_Name, string ıD_Card, string email, string birthdate)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            ID_Card = ıD_Card;
            Email = email;
            Birthdate = birthdate;
        }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string ID_Card { get; set; }
        public string Email { get; set; }
        public string Birthdate { get; set; }



        //The most important method in my prototype design pattern is the method we apply below.
        //I created my method in my "IPrototypeStudent" interface.
        //In the body of the method, I used the "MemberwiseClone()" method embedded in "C#" to create a copy of an object produced from this class within the class to be used.
        //I gave the return type the same as my interface. In return, it gave me a copy of my object.

        public IPrototypeStudent Clone()
        {
            return this.MemberwiseClone() as IPrototypeStudent;
        }
    }
}

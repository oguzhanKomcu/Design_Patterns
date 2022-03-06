using Prototype_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //I marked my object in the variable "Student1".

            //If we think about our scenario like this, let's say I had to create it from the same object again.
            //Here, I get rid of an object generation again by using this design pattern.

            Student student1 = new Student("Oğuzhan", "Kömcü", "88875964785", "komcuoguz@gmail.com", "1995");
            Student student2 = (Student)student1.Clone();


            //let's check

            Console.WriteLine($"Name = {student2.First_Name}");

            Console.ReadLine();








        }
    }
}

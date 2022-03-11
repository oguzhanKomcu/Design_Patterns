using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContactTransporter transporter = new ContactTransporter();
            transporter.AddContact(new Contact() { FirtsName= "Oğuzhan",LastName="Kömcü",Email="komcuoguzz@gmail.com",PhoneNumber= "05345601647"});
            transporter.AddContact(new Contact() { FirtsName = "Ozan", LastName = "Yılmaz", Email = "ozan@gmail.com", PhoneNumber = "05555560448" });
            transporter.AddContact(new Contact() { FirtsName = "Elif", LastName = "Yiğit", Email = "elif@gmail.com", PhoneNumber = "05346859747" });

            var iterator = transporter.CreateIterator();

            while (iterator.Next())
            {
                Console.WriteLine(iterator.CurrentItem.FirtsName);
            }
            Console.ReadLine();


            // The iterator's algorithm may vary. When it comes to this,
            // all you have to do is develop another iterator using the same interface and return this object over the container.
            //Your client code (main above) can run without any modifications.
            //The Iterator engine can work not only with the Category element, but also with any other as needed.
        }
    }
}

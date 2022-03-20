using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            News_Website news_Website = new News_Website();
            news_Website.News_Name = "Looking for new in technology";
            news_Website.Explanation = "Oğuzhan's new product was met with great interest and received a lot of investment.";
            news_Website.New_News = true;
     

            if (news_Website.New_News == true)
            {
                news_Website.Client_Add(new MobilApp());
                news_Website.Client_Add(new Website());
                news_Website.Notify();
            }
      
     

            Console.ReadKey(true);
        }
    }
}

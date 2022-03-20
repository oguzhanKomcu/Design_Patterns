using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Design_Pattern
{
    public  class News_Website
    {
      
        public string News_Name { get; set; }      
        public string Explanation { get; set; }



        public bool New_News { get; set; }      
       


        List<IObserver> observers;
        public News_Website()
        {
            this.observers = new List<IObserver>();
        }
        //Gözlemci ekle
        public void Client_Add(IObserver observer)
        {
            observers.Add(observer);
        }
        //Gözlemci çıkar

        public void Notify()
        {
            observers.ForEach(g =>
            {
                g.Update();
            });
        }

    }
}

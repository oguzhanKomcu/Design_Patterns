using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Design_Pattern;

namespace Visitor_Design_Pattern.Classes
{

    /// <summary>
    ///  The 'ConcreteElement' class
    /// </summary>
    public class Products : IBaseEntity
    {



        public int ID { get; set; }
        public string Name { get; set; }

        public decimal  Price { get; set; }

        public string UnitInStock { get; set; }





        public  void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

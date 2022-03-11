using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Design_Pattern;

namespace Visitor_Design_Pattern.Classes
{
    // The 'ConcreteElement' class
    public class Categories : IBaseEntity
    {

        public int Id { get; set; } 
        public string Name { get; set; }
        public  string Description { get; set; }    

        public  void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

       
    }
}

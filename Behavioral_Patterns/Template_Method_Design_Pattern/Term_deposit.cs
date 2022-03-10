using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern
{
    public class Term_deposit : Bank_Account
    {
        public override void Account()
        {
            account_Type = Account_Type.Term_deposit;
        }

        public override void Interest_Type(Term_Type term_Type1)
        {
            term_Type = term_Type1;

        }


        //Subclasses have to implement all the abstract operations of the base class,
        //but by themselves it does not override the template method.
        //Since I did not mark the template method as abstract,
        //we did not override it here, but when I create an object from my concrete class,
        //it will appear in my template method.
    }
}

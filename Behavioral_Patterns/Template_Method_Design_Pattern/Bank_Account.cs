using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method_Design_Pattern
{

  
    public abstract class Bank_Account
    {


        //In this abstract class I've created,
        //I define a template method that contains some methods,
        //usually consisting of calls to abstract primitive operations.
        //Concrete subclasses implement these operations,
        //but leave the template method itself as is.


        protected Account_Type account_Type;

        protected Term_Type term_Type;

        // PrimitiveOperation
        void Start()
        {
            Console.WriteLine("A bank account is created.");
        }
        void Finish() 
        {
            Console.WriteLine($"Your account type:{account_Type}\nTerm type of your account:{term_Type}"); 
        }



        public abstract void Account();
         public abstract void Interest_Type(Term_Type term_Type);

        //Thanks to the "TemplateMethod" I created in my abstract class,
        //it will be called directly here without triggering my methods one by one.
        public void TemplateMethod( Term_Type term_Type)
        {
            Start();
            Account();
            Interest_Type(term_Type);
            Finish();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abstract Classes vs Intefaces


namespace Drill
{


    public abstract class Abstract_Class
    {
        interface Itest
        {
            void AMethod();
            string GetWords();
        }
        public class Abstract_Interface
        {
        }
        public abstract void getAbstract();

        abstract class Interface_class : Itest
        {
            public void AMethod()
            {
            }
            abstract public string GetWords();
        }
    }
}

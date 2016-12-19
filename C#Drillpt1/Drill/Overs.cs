using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Overloading/Overriding/Public/Private/
namespace Drill
{
    public class Overs
    {
        public virtual void Example()
        {
            Console.WriteLine("This is an Example");
        }
        private void Example(int ExampleNumber)
        {
            Console.WriteLine("This is an overloaded Example" + ExampleNumber);
        }
        //Abstract internal class
        internal abstract class Drill : Overs
        {
            //Override initial method
            public override void Example()
            {
                base.Example();
                Console.WriteLine("Override the class");
            }
            static void Main(string[] args)
            {


            }
        }
    }
}

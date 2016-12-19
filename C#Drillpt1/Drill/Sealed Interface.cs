//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Drill
//{
//    class Sealed_Interface
//    {
//        private interface Ihi
//        {
//            void SayHello();
//        }
//        public class A : Ihi
//        {
//            int x = 5;
//            public virtual void function(int x)
//            {
//                Console.WriteLine(x * 2);
//            }
//            public void SayHello()
//            {
//                Console.WriteLine("Hello");
//            }
            
//        }
//        internal sealed class B : A
//        {
//            int x = 3;
//            public override void function(int x)
//            { 
//            }

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Usage of Delegates and multcast delegate

namespace Drill
{
    delegate void BreakfastDel(string s);

    class Delegates
    {
        static void Eggs(string s)
        {
            Console.WriteLine("{0} Likes Eggs!", s);
        }
        static void Bacon(string s)
        {
            Console.WriteLine("{0} likes Bacon!");
        }
        
        static void Main2()
        {
            BreakfastDel DelegateEggs, DelegateBacon, DelegateBoth;

            DelegateEggs = Eggs;
            DelegateBacon = Bacon;
            DelegateBoth = DelegateEggs + DelegateBacon;

            DelegateEggs("Johnny");
            DelegateBacon("Joey");
            DelegateBoth("Satan");
        }
             
    }
}

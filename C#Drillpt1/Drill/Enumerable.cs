using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Usage of an Enumerable
namespace Drill
{

    public enum Breakfast
    {
        Eggs,
        Bacon,
        Muffin,
        Bagel,
        Cereal
    }
    public class Morning
    {
        public virtual void GoodMorning()
        {
            Console.WriteLine("1. Eggs, 2. Bacon, 3. Muffin, 4. Bagel, 5. Cereal");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine(Breakfast.Eggs);
            }
            else if (choice == "2")
            {
                Console.WriteLine(Breakfast.Bacon);
            }
            else if (choice == "3")
            {
                Console.WriteLine(Breakfast.Muffin);
            }
            else if (choice == "4")
            {
                Console.WriteLine(Breakfast.Bagel);
            }
            else
            {
                Console.WriteLine(Breakfast.Cereal);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("How Many hours of sleep did you get last night?");
            int hoursofSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            if (hoursofSleep > 8)
            {
                Console.WriteLine("You are Well Rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }
        }
    }
}

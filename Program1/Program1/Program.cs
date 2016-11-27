using System;

namespace Program1
{
    public class Program
    {
        //This is where the program starts.
        static void Main(string[] args)
        {
            //Ask user to enter a name.
            Console.WriteLine("Enter your name, please:");

            //Now read the name entered
            string name = Console.ReadLine();

            //Greet the User with the entered name
            Console.WriteLine("Hello, " + name);

            //Wait for the User to acknowledge
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}

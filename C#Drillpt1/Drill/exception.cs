using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


//Try Catch Finally and Exception handling
namespace Drill
{
    public class exception
    {
        private static void LogError(FormatException ex)
        {
            string message = ex.Message;
            message += Environment.NewLine;
            message += "-------------------";
            message += Environment.NewLine;
            message += (DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss,ff"));
            using (StreamWriter writer = new StreamWriter("logfile.txt", true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }
        static void Main3(string[] args)
        {
            //Ask user to enter a name.
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            try
            {
                Regex.IsMatch(Console.ReadLine(), @"^[a-zA-Z]+$");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid name");
                LogError(ex);
            }
            finally
            {
                Console.WriteLine("completed");
            }
            //Now read the name entered

            Console.WriteLine("Hello, " + name);
        }
    }

}

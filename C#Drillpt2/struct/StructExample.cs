using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///Usage of Struct class and this statement


namespace @struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team;

            team = new Team("Blazers");
            Console.WriteLine(team.Describe());

            team = new Team("Lakers");
            Console.WriteLine(team.Describe());

            Console.ReadKey();
        }
    }

    struct Team
    {
        private string name;

        public Team(string name)
        {
            this.name = name;
        }

        public string Describe()
        {
            return "This team's name is " + Name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

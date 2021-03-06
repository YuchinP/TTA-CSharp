﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* delegates*/

delegate double GetSum(double num1, double num2);

namespace TutorialApplciation2
{


    /*enumes*/
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }
/* structures*/
    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("ID " + id);
        }
    
    }
    class Animal
    {

        static void Main(string[] args)
        {
            Temperature micTemp = Temperature.Warm;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));

            /*lambda*/
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach(int num in oddNums)
            {
                Console.WriteLine(num + ",");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string personsAge = Console.ReadLine();
            int age = Convert.ToInt32(personsAge);
            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string personsTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(personsTickets);

            Console.WriteLine("Qualifies?");
            bool qualifies = (age > 15 && tickets == 0 && dui == "false");
            Console.WriteLine(qualifies);
            

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearBorn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age <= 0) Console.WriteLine("Please pick a positive number greater than 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            int difference = (2019 - age);
            Console.WriteLine("You were born in the year " + difference);
            Console.ReadLine();

        }
    }
}

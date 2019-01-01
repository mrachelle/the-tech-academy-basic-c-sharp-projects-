using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Pick a whole number");
            double value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In " + value + " hours the time will be " + DateTime.Now.AddHours(0 + value));
            Console.ReadKey();
        }
    }
}

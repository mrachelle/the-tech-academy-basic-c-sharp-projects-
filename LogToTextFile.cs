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
            Console.WriteLine("Please pick a number");
            string text = Console.ReadLine();
            System.IO.File.WriteAllText(@"C:\Users\mariv\Desktop\NOTES\log.txt", text);

        }
    }
}

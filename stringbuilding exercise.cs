using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Greetings. ");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Okay " + name + ", thank you for your time. What would you say is your biggest strength?");
            string userStrength = Console.ReadLine();
            string strength = userStrength.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(". My biggest strength is " + strength + ". ");

            Console.WriteLine("And why do you think you will be a good fit for our company? ");

            string fit = Console.ReadLine();
            sb.Append("I think I would be a good fit for this position because " + fit);

            Console.WriteLine("Hello, my name is " + name + sb + ". Thank you for your time" ); 
            Console.ReadKey();


        }
    }
}

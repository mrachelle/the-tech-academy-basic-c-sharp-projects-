using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number that isn't prime number between 1 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 is first prime number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2 is the only even prime number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("3 is definitely prime.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("5 is a prime number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Lucky number 7 is a prime number");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Good work!");
                        Console.WriteLine("That is not a prime number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            }

            while (!isGuessed);
            
            
            Console.Read();
        }
    }
}

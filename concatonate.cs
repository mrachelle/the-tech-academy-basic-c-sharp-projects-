using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Bender Bending Rodriguez";
            int age = 4;
            string composition = "zinc, titanium, iron, dolomite, lead, empty, back ";
            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("Robot's Name: " + name + ". Robot's Age: " + age + ". Robot's composition: " + composition);
            

            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}

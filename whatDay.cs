using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What day of the week is it?");
        string input = Console.ReadLine();
        DayOfTheWeek day;
            
        try
        {
            day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), input);
        }
        catch
        {
            Console.WriteLine("Please enter an actual day of the week");
        }

        Console.ReadLine(); 
    }
    public enum DayOfTheWeek
    {
        Sunday=0,
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=0
    }
}


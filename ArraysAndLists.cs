using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colonies = new string[] { "VA", "NY", "MA", "MD", "RI", "CT", "NH", "DE", "NC", "SC", "NJ", "PA", "GA" };
            Console.WriteLine("There were 13 original colonies. Choose a number in the array to see which state that was. ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(colonies[userInput]);
            Console.ReadKey();

            int[] coloniesYear = new int[] { 1626, 1630, 1633, 1636, 1636, 1638, 1638, 1653, 1663, 1664, 1682, 1732 };
            Console.WriteLine("Select an index in the array of the 13 original colonies to see what year they were established. ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(coloniesYear[userInput2]);
            Console.ReadKey();

            List<string> state = new List<string>();
            state.Add("25JUN1788");
            state.Add("26JUL1788");
            state.Add("06FEB1788");
            state.Add("28APR1788");
            state.Add("29MAY1790");
            state.Add("09JAN1788");
            state.Add("21JUN1788");
            state.Add("07DEC1787");
            state.Add("21NOV1789");
            state.Add("23MAY1788");
            state.Add("18DEC1787");
            state.Add("12DEC1787");
            state.Add("02JAN1788");
            Console.WriteLine("Select an index from the array to see when that corresponding colony officially became a state. ");
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(state[userInput3]);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Day");
            string Day = Console.ReadLine();

            switch (Day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("It's Weekday");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("It's Weekend");
                    break;
                default:
                    Console.WriteLine("Please provide a Day");
                    break;
            }
            Console.ReadLine();
        }
    }
}

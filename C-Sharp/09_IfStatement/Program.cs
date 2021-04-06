using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("You are an Adult Now");
            }
            else
            {
                Console.WriteLine("You are a Minor, wait for your time");
            }
            Console.ReadLine();
        }
    }
}

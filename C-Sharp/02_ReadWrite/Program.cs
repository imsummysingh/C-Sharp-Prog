using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string name=Console.ReadLine();
            Console.WriteLine("Are you really " + name +" !");
            Console.ReadLine();
        }
    }
}

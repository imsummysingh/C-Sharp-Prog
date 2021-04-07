using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Delegate
{
    public delegate void HelloDelegateFunction(string message);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegateFunction del = new HelloDelegateFunction(Hello);
            del("Hello from delegate to function");

            Console.ReadLine();

        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Delegate
{
    public delegate void HelloDelegateFunction(string message);
    //public delegate void Hello21Del(string message, string message1);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegateFunction del = new HelloDelegateFunction(Hello);
            del("Hello from delegate to function");

            //Hello21Del del1 = new Hello21Del(Hello21);
            //del1("Hello","Hello1");

            Console.ReadLine();

        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        //public static void Hello21(string msg, string msg2)
        //{
        //    Console.WriteLine(msg, msg2);
        //}
    }
}

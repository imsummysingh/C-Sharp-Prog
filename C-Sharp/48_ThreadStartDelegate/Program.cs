using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _48_ThreadStartDelegate
{
    public class Number
    {
        public static void PrintNumbers()
        {
            for(int i=0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start();
            Console.ReadLine();
        }
    }
}

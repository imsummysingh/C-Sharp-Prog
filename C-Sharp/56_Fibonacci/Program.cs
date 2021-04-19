using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            int s = 1;
            Console.WriteLine(f);
            Console.WriteLine(s);
            for(int i = 1; i < 10; i++)
            {
                int fibo = f + s;
                Console.WriteLine(fibo);
                f = s;
                s = fibo;
            }
            Console.ReadLine();
        }
    }
}

//f0 s1, f1 s2 3 5 

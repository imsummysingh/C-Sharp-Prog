using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float j = i;
            Console.WriteLine("Before Conversion :{0}", i);
            Console.WriteLine("After Conversion: {0}", j);
            Console.ReadLine();
        }
    }
}

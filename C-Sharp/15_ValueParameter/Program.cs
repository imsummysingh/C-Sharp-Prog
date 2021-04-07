using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ValueParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            SimpleMethod(i);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public static void SimpleMethod(int j)
        {
            j = 101;
        }
    }
}

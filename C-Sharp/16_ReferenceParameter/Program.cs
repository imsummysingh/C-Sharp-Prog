using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ReferenceParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            ReferenceMethod(ref i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
        public static void ReferenceMethod(ref int j)
        {
            j = 101;
        }
    }
}

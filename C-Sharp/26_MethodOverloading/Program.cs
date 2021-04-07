using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Add(2, 3);
            Add(10, 20, out sum);

            Console.ReadLine();
        }

        public static void Add(int x, int y)
        {
            Console.WriteLine("Sum is: {0}", x+y);
        }

        public static void Add(int x, int y, out int sum)
        {
            sum = x + y;
            Console.WriteLine("Sum is with Out {0}", sum);
        }
    }
}

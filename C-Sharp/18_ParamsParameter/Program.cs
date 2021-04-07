using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ParamsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[3];
            Numbers[0] = 100;
            Numbers[1] = 101;
            Numbers[2] = 102;
            ParamsMethod(Numbers);

            ParamsMethod(1, 2, 3, 4, 5);

            Console.ReadLine();
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("There are {0} elements",Numbers.Length);

            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}

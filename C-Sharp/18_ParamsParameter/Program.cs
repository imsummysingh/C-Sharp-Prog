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

            //ParamArray(1);
            //ParamArray(1, 2);
            ParamArray(0, 2, 3, 4, 5, 6, 7);

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

        public static void ParamArray(int a, params int[] arr)
        {
            Console.WriteLine("Another param Array");
            Console.WriteLine(a);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}

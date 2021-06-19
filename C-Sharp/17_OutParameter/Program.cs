using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total = 0;
            int Product = 0;
            int Subs = 0;
            CalculateSum(10, 20, out Total, out Product,out Subs);
            Console.WriteLine("Sum is: {0} & Product is: {1} & Substraction is :{2}", Total, Product, Subs);
            Console.ReadLine();
        }

        public static void CalculateSum(int FN,int SN, out int sum, out int product, out int subs)
        {
            sum = FN + SN;
            product = FN * SN;
            subs = FN - SN;
        }
    }
}

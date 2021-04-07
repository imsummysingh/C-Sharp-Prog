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
            CalculateSum(10, 20, out Total, out Product);
            Console.WriteLine("Sum is: {0} & Product is: {1}", Total, Product);
            Console.ReadLine();
        }

        public static void CalculateSum(int FN,int SN, out int sum, out int product)
        {
            sum = FN + SN;
            product = FN * SN;
        }
    }
}

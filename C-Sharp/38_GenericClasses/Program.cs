using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_GenericClasses
{
    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual<int>(2, 1);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            Console.ReadLine();
        }
    }
}

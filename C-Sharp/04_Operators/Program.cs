using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Operator =
            //Arithmetic Operators like +,-,*,/,%
            //Comparison Operators like ==, !=,>, >=, <, <=
            //Conditional Operators like &&, ||
            //Ternary Operator ?:
            //Null Coalescing Operator ??

            Console.WriteLine("Assignment Operator");
            int d = 10;
            int Date = d;
            Console.WriteLine("Date: " + Date);


            Console.WriteLine("Arithmetic Operators");
            int i = 40, j = 20;
            Console.WriteLine("i & j is:", +i, +j);
            Console.WriteLine("Addition: ", i + j);
            Console.WriteLine("Substraction: ", i - j);
            Console.WriteLine("Multiplication: ", i * j);
            Console.WriteLine("Division: ", i / j);
            Console.WriteLine("Module: ", i % j);

            Console.ReadLine();

        }
    }
}

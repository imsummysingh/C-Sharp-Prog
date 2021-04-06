using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ExplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //float i = 400.123F;
            ////int j = (int)i;

            ////convert class
            //int j = Convert.ToInt32(i);

            //Console.WriteLine("Before Explicit Conversion of Float: {0}", i);
            //Console.WriteLine("After Explicit Conversion of Float:{0}", j);
            //Console.ReadLine();

            float f = 100.25F;

            // Cannot implicitly convert float to int.
            // Fractional part will be lost. Float is a
            // bigger datatype than int, so there is
            // also a possiblity of overflow exception
            // int i = f;

            // Use explicit conversion using cast () operator
            int i = (int)f;

            // OR use Convert class
            // int i = Convert.ToInt32(f);

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

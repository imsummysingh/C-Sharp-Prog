using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_Enum
{
    class Program
    {
        public enum Colors
        {
            red,            //0
            green,          //1
            blue=5,         //5
            purple,         //6
            black,          //7
            violet=9,       //9  
            orange          //10
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Colors.red);
            Console.WriteLine(Colors.blue);
            Console.WriteLine(Colors.purple);
            Console.WriteLine(Colors.violet);
            Console.WriteLine(Colors.orange);

            Console.ReadLine();
        }
    }
}

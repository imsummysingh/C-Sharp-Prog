using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ExplicitInterface
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }

    public class Me : I1, I2
    {
        public void Print()
        {
            Console.WriteLine("Explicit Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Me m = new Me();
            m.Print();
            ((I2)m).Print();

            Console.ReadLine();
        }
    }
}

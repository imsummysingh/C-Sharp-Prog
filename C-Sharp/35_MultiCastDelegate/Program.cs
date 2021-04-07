using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_MultiCastDelegate
{
    public delegate void SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegate del1 = new SampleDelegate(SampleMethodOne);
            SampleDelegate del2 = new SampleDelegate(SampleMethodTwo);
            SampleDelegate del3 = new SampleDelegate(SampleMethodThree);
            SampleDelegate del4 = del1 + del2 + del3 - del2;

            del4();

            Console.ReadLine();

        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }


        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }


        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_MultipleInterface
{
    interface IA
    {
        void PrintA();
    }
    public class A: IA
    {
        public void PrintA()
        {
            Console.WriteLine("Interface A");
        }
    }

    interface IB
    {
        void PrintB();
    }
    public class B: IB
    {
        public void PrintB()
        {
            Console.WriteLine("Inetrface B");
        }
    }

    public class All: IA, IB
    {
        A a = new A();
        B b = new B();
        public void PrintA()
        {
            a.PrintA();
        }
        public void PrintB()
        {
            b.PrintB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            All all = new All();
            all.PrintA();
            all.PrintB();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_AbstractClass
{
    //interface I1
    //{
    //    void P1();
    //}
    public abstract class Customer
    {
        //public void P1()
        //{
        //    Console.WriteLine
        //}
        public void print()
        {
            Console.WriteLine("Hello From Abstract Class");
        }
        public abstract void print1();
    }

    public class Implemented : Customer
    {
        public void Print()
        {
            Console.WriteLine("Another Method");
        }
        public void print()
        {
            Console.WriteLine("From ANother Class which implemented abstract");
        }
        public override void print1()
        {
            Console.WriteLine("OF abstract");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Implemented im = new Implemented();
            im.Print();
            im.print();
            im.print1();

            Console.ReadLine();
        }
    }
}

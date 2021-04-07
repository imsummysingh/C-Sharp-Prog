using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_AbstractClass
{
    public abstract class Customer
    {
        public void print()
        {
            Console.WriteLine("Hello From Abstract Class");
        }
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Implemented im = new Implemented();
            im.Print();
            im.print();


            Console.ReadLine();
        }
    }
}

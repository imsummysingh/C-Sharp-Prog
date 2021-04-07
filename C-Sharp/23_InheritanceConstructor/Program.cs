using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_InheritanceConstructor
{
    public class parent
    {
        public parent()
        {
            Console.WriteLine("Parent Class Constructor");
        }
        public parent(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class child : parent
    {
        public child():base("Overloaded Parent class parameterized constructor controlled by child class")
        {
            Console.WriteLine("Child Class Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child c = new child();

            Console.ReadLine();
        }
    }
}

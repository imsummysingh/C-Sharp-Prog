using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_InheritanceConstructor
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }
    }
    class Child: Parent
    {
        public Child()
        {
            Console.WriteLine("Child COnstructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.ReadLine();
        }
    }
}

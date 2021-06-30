using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_MethodOverriding
{
    class Parent
    {
        public string Name;

        public virtual void FullName()
        {
            Console.WriteLine("Parent Name: {0}", Name);
        }
    }
    class Child : Parent
    {
        public override void FullName()
        {
            Console.WriteLine("Child Name: {0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Name = "Summy";
            p.FullName();       //parent

            Child c = new Child();
            c.Name = "Sunny";
            c.FullName();       //child

            Parent p1 = new Child();
            p1.Name = "Ranjeet";
            p1.FullName();      //child

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_MethodHiding
{
    class Parent
    {
        public string Name;
        public void FullName()
        {
            Console.WriteLine("Full Name Through Parent: {0}", Name);
        }
    }
    class Child : Parent
    {
        public new void FullName()
        {
            Console.WriteLine("FullName through Child:{0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Name = "Summy";
            p.FullName();           //parent    

            Child c = new Child();
            c.Name = "Sunny";
            c.FullName();           //child

            Parent p1 = new Child();
            p1.Name = "Ranjeet";
            p1.FullName();          //parent

            Console.ReadLine();
        }
    }
}

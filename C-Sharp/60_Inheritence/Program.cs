using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Inheritence
{
    public class Base
    {
        public void print()
        {
            Console.WriteLine("Base");
        }
    }
    public class Derived : Base
    {
        public new void print()
        {
            Console.WriteLine("Derived");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.print();  //base

            Base b1 = new Derived();
            b1.print();     //base

            Derived d = new Derived();
            d.print();  //derived

            //Derived d = new Base(); //cannot implicit conversion
            //d.print();

            Console.ReadLine();
        }
    }
}

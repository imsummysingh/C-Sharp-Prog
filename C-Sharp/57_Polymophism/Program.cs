using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Polymophism
{
    public class Base
    {
        public virtual void print()
        {
            Console.WriteLine("Base");
        }
    }
    public class Derived: Base
    {
        public override void print()
        {
            Console.WriteLine("Derived");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.print();      //base

            Base b1 = new Derived();
            b1.print();     //derived

            Derived d = new Derived();
            d.print();  //derived

            //Derived d1 = new Base();    //cannot implicit convert
            //d1.print();

            //((Employee)PTE).FullName();
            //((Base)d).print();

            Console.ReadLine();
        }
    }
}

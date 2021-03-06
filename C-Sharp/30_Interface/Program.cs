using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Interface
{
    interface I1
    {
        void Print();
    }
    interface I2 {
        void Print1();
    }

    interface I3 : I1
    {
        //print()
        void Print2();
    }
    public class Consumer
    {
        public void Print4()
        {
            Console.WriteLine("Hello from class not interface");
        }
    }
    public class InterfaceImplement: Consumer,I2, I3
    {
        public void Print()
        {
            Console.WriteLine("Calling Interface 1 through Interface 3");
        }
        public void Print1()
        {
            Console.WriteLine("Calling Interface 2");
        }
        public void Print2()
        {
            Console.WriteLine("Calling Interface 3");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            InterfaceImplement im = new InterfaceImplement();
            im.Print();
            im.Print1();
            im.Print2();
            im.Print4();

            I1 i = new InterfaceImplement();
            i.Print();

            I2 i2 = new InterfaceImplement();
            i2.Print1();

            Console.ReadLine();
        }
    }
}

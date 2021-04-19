using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_ClassObject
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }

        public void print()
        {
            Console.WriteLine("First Name:{0} & Last Name:{1}", Fname, Lname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Fname = "Summy";
            e1.Lname = "Singh";
            e1.print();     //summy singh

            Employee e2 = new Employee();
            e2 = e1;
            e2.print();     //summy singh

            Employee e3 = new Employee();
            e3 = e1;
            e3.Fname = "Sunny";
            e3.print();     //sunny singh

            Console.ReadLine();
        }
    }
}

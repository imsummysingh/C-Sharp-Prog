using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Constructor
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default");
        }
        static Employee()
        {
            Console.WriteLine("Static");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();    //static Default

            Employee e1 = new Employee();   //Default

            Console.ReadLine();
        }
    }
}

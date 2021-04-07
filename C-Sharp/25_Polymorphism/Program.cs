using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Polymorphism
{
    public class Employee
    {
        public string FirstName="Summy";
        public string LastName="Singh";

        public virtual void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTime: Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -FullTime");
        }
    }
    public class PartTime : Employee
    {
        public override void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " -PartTime");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FullName();

            Employee emp1 = new FullTime();
            emp1.FullName();

            Employee emp2 = new PartTime();
            emp2.FullName();

            Console.ReadLine();
        }
    }
}

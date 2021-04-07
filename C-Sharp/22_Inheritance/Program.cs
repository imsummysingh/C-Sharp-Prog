using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee: Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee: Employee
    {
        public float HourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Summy";
            FTE.LastName = "Singh";
            FTE.YearlySalary = 540000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Ranjeet";
            PTE.LastName = "Kumar";
            PTE.HourlyRate = 1000;
            PTE.PrintFullName();


            Console.ReadLine();
        }
    }
}

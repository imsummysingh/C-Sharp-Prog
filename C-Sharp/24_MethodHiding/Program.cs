using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MethodHiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;

        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class PartTimeEmployee : Employee
    {

        //Hiding of base class method
        public new void FullName()
        {
            //Calls the base class method
            //base.FullName();

            Console.WriteLine(FirstName + " " + LastName + " -Contract Basis");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee EMP = new Employee();
            EMP.FirstName = "Summy";
            EMP.LastName = "Singh";
            EMP.FullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Ranjeet";
            PTE.LastName = "Kumar";
            PTE.FullName();

            //((Employee)PTE).FullName();   //--calls the base class method and override the own method
            Employee e1 = new PartTimeEmployee();
            e1.FirstName = "Shhubham";
            e1.LastName = "Gupta";
            e1.FullName();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Indexer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployee;

        public Company()
        {
            listEmployee = new List<Employee>();

            listEmployee.Add(new Employee { EmployeeId = 1, Name = "Summy", Gender = "Male" });
            listEmployee.Add(new Employee { EmployeeId = 2, Name = "Ranjeet", Gender = "Male" });
            listEmployee.Add(new Employee { EmployeeId = 3, Name = "Vishal", Gender = "Male" });
            listEmployee.Add(new Employee { EmployeeId = 4, Name = "Shubham", Gender = "Male" });
            listEmployee.Add(new Employee { EmployeeId = 5, Name = "Vicky", Gender = "Male" });
        }
        // Use "this" keyword to create an indexer
        // This indexer takes employeeId as parameter
        // and returns employee name
        public string this[int employeeId]
        {
            get
            {
                return listEmployee.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Console.WriteLine("Employee with id: 1 and Name:{0}", c[1]);
            Console.WriteLine("Employee with id: 3 and Name:{0}", c[3]);
            Console.WriteLine("Employee with id: 5 and Name:{0}", c[5]);

            Console.WriteLine("After Changing Value through indexer");

            c[3] = "Vishal Vaibhav";
            Console.WriteLine("Employee with id: 3 and Name:{0}", c[3]);

            //c[6] = "Gupta";
            //Console.WriteLine("Employee with id: 6 and Name:{0}", c[6]);

            Console.ReadLine();
        }
    }
}

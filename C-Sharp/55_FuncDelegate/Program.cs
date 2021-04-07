using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_FuncDelegate
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mary"},
            };

            Func<Employee, string> selector = employee => "Name = " + employee.Name;
            IEnumerable<string> names = listEmployees.Select(selector);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}

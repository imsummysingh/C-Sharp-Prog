using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_EarlyBinding
{
    public class Customer
    {
        public string FullName(string fname, string lname)
        {
            return fname + lname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            string fullname = c1.FullName("Summy", "Singh");
            Console.WriteLine("Your full name is {0}", fullname);
            Console.ReadLine();
        }
    }
}

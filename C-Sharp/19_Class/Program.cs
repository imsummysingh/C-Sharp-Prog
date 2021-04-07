using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class
{
    public class Customer
    {
        string FirstName;
        string LastName;

        public Customer():this("Summy","Singh")
        {
    
        }

        public Customer(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public void FullName()
        {
            Console.WriteLine("First Name: {0} & Last Name: {1}", this.FirstName, this.LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.FullName();

            Customer c1 = new Customer("Summy", "Singh");
            c1.FullName();


            Console.ReadLine();
        }
    }
}

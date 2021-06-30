using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_ConstructorChaining
{
    public class Customer
    {
        int age;
        string Name;
        public Customer():this(25)
        {
            Console.WriteLine("Constructor 1");            
            
        }
        public Customer(int Age): this("Summy")
        {
            Console.WriteLine("Constructor 2 after default");
            Console.WriteLine("Age is:{0}", Age);
        }
        public Customer(string Name)
        {
            Console.WriteLine("Constructor 3 after constructor 2");
            Console.WriteLine("Name is:{0}", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            Console.ReadLine();
        }
    }
}

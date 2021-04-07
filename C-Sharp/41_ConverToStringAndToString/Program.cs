using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_ConverToStringAndToString
{
    public class Customer
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = null;
            //Console.WriteLine(c1.ToString());   --NullReferenceException
            Console.WriteLine(Convert.ToString(c1));

            Console.ReadLine();
        }
    }
}

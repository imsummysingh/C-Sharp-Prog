using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Dictionary
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            // Create Customer Objects
            Customer customr1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customr2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customr3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

            // Retrieve the value (Customer object) from the dictionary,
            // using key (customer ID). The fastest way to get a value
            // from the dictionary is by using its key
            Console.WriteLine("Customer 101 in customer dictionary");
            Customer cus101 = dictionaryCustomers[101];
            Console.WriteLine("Customer Id:{0}, Customer Name:{1}, Customer Salary:{2}",cus101.ID,cus101.Name,cus101.Salary);

            Console.WriteLine("--------------------------------------------------");

            // It is also possible to loop thru each key/value pair in a dictionary
            Console.WriteLine("All customer keys and values in customer dictionary");

            foreach(KeyValuePair<int,Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }

            Console.WriteLine("--------------------------------------------------");

            // You can also use implicitly typed variable VAR to 
            // loop thru each key/value pair in a dictionary. But try
            // to avoid using var, as this makes your code less readable
            Console.WriteLine("All customer keys and values in customer dictionary");

            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the keys in the dictionary
            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");

            // To get all the values in the dictionary
            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            Console.ReadLine();
        }
    }
}

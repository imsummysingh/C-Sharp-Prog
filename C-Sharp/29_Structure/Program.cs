using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Structure
{
    class Program
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public void Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id:{0} & Name:{1}", this._id, this._name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Customer(101, "Summy");
            p.PrintDetails();

            Program p1 = new Program();
            p1.Customer(102, "Ranjeet");
            p1.PrintDetails();

            Program p2 = new Program();
            p2.Id = 103;
            p2.Name = "Shubham";
            p2.PrintDetails();

            Program p3 = new Program
            {
                Id = 104,
                Name = "Vicky"
            };
            p3.PrintDetails();

            Console.ReadLine();
        }
    }
}

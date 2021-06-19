using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Properties
{
    class Program
    {
        private int _id;
        public string _name;
        public int _passMark;
        
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be Empty");
                }
                this._name = value;
            }
            get
            {
                if (string.IsNullOrEmpty(this._name))
                {
                    return "No Name";
                }
                else
                {
                    return this._name;
                }
            }
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id cannot be Negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Id = 101;
            p.Name = "Summy";
            Console.WriteLine("Details are: {0}, {1}", p.Id, p.Name);
            Console.ReadLine();
        }
    }
}

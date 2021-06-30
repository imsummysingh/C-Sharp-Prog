using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Properties
{
    class Prop
    {
        private string _name;
        public string Name
        {
            set
            {
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prop p = new Prop();
            p.Name = "Summy";
            Console.WriteLine("Name is: {0}", p.Name);

            Console.ReadLine();
        }
    }
}

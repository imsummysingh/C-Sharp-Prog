using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_GetterSetter
{
    class Program
    {
        private int _id;
        public string _name;
        public int _passMark;

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
            }
            this._name = name;
        }
        public string GetName()
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return _name;
            }
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                Console.WriteLine("Id cannot be negative");
            }
            this._id = Id;
        }
        
        public int GetId()
        {
            return _id;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SetId(-1);
            Console.WriteLine("Id is: {0}", p.GetId());

            Console.ReadLine();
        }
    }
}

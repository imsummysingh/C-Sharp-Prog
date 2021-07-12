using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_PrivateConstructor1
{
    public class PrivCons
    {
        public static string name;
        public static int age;

        private PrivCons()
        {
            Console.WriteLine("Private Constructor");
        }

        public PrivCons(string _name,int _age)
        {
            name = _name;
            age = _age;

            Console.WriteLine("Called from Another Constructor Where Name:{0}, Age:{1}", name, age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //in this case private constructor won't be called
            PrivCons cons = new PrivCons("Summy", 25);

            PrivCons cons1 = new PrivCons("Sunny", 28);

            Console.ReadLine();
        }
    }
}

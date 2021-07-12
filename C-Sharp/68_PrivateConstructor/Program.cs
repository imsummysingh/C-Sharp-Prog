using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_PrivateConstructor
{
    public class PrivCons
    {
        private PrivCons()
        {
            Console.WriteLine("Private Constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //inaccsibble due to access level
            PrivCons con = new PrivCons();
        }
    }
}

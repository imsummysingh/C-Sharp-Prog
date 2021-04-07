using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Generic2
{
    public class GFG<T>
    {
        private T data;
        public T value
        {
            get { return this.data; }
            set
            {
                this.data = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GFG<string> gfg = new GFG<string>();
            gfg.value = "Summy";
            Console.WriteLine("First: {0}", gfg.value);

            GFG<int> gfg1 = new GFG<int>();
            gfg1.value = 10;
            Console.WriteLine("Second: {0}", gfg1.value);

            Console.ReadLine();
        }
    }
}

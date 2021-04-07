using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.EvenNumber(20);

            Program p = new Program();
            int sum = p.Add(2, 3);
            Console.WriteLine("Sum is: {0}", sum);

            Console.ReadLine();
        }

        //Normal Function
        public int Add(int x,int y)
        {
            return x + y;
        }

        //static method
        public static void EvenNumber(int Target)
        {
            int start = 0;
            while (start <= Target)
            {
                Console.WriteLine("Even Numbers: {0}", start);
                start = start + 2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] EvenNumber = new int[3];
            EvenNumber[0] = 0;
            EvenNumber[1] = 2;
            EvenNumber[2] = 4;

            int[] OddNumber = { 1, 3, 5 };

            Console.WriteLine("Even Numbers");
            for(int i = 0; i < EvenNumber.Length; i++)
            {
                Console.WriteLine(EvenNumber[i]);
            }

            Console.WriteLine("Odd Numbers");
            for(int i = 0; i < OddNumber.Length; i++)
            {
                Console.WriteLine(OddNumber[i]);
            }
            Console.ReadLine();
        }
    }
}

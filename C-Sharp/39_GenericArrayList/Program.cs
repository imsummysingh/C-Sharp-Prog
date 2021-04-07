using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_GenericArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arr = new ArrayList(4);
            Arr.Add(1);
            Arr.Add(2);
            Arr.Add(3);
            Arr.Add(4);
            Arr.Add(1);
            Arr.Add(2);
            Arr.Add(3);
            Arr.Add(4);
            Arr.Add("Summy");
            Arr.Add("Singh");
            Arr.Add("Software Developer");

            foreach(int i in Arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

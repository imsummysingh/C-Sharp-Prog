using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _43_OptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNumber(1, 2);
            //AddNumber(2, 3, 5);
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
            AddNumbers(10, 20, null);
            Console.ReadLine();
        }

        //Use parameter arrays

        //public static void AddNumber(int f,int l, params object[] Total)
        //{
        //    int result = f + l;
        //    foreach(int i in Total)
        //    {
        //        result += i;
        //    }
        //    Console.WriteLine("Total: {0}", result.ToString());
        //}
        //public static void AddNumber(int f, int l, params int[] Total)
        //{
        //    int result = f + l;
        //    foreach (int i in Total)
        //    {
        //        result += i;
        //    }
        //    Console.WriteLine("Total: {0}", result);
        //}

        //Method overloading
        public static void AddNumbers(int firstNumber, int secondNumber,int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = " + result);
        }

        //Specify parameter defaults
        //public static void AddNumbers(int firstNumber, int secondNumber,int[] restOfTheNumbers = null)
        //{
        //    int result = firstNumber + secondNumber;

        //    // loop thru restOfTheNumbers only if it is not null
        //    // otherwise you will get a null reference exception
        //    if (restOfTheNumbers != null)
        //    {
        //        foreach (int i in restOfTheNumbers)
        //        {
        //            result += i;
        //        }
        //    }
        //    Console.WriteLine("Total = " + result.ToString());
        //}

        //Use OptionalAttribute

        //public static void AddNumbers(int firstNumber, int secondNumber,[Optional] int[] restOfTheNumbers)
        //{
        //    int result = firstNumber + secondNumber;

        //    // loop thru restOfTheNumbers only if it is not null
        //    // otherwise you will get a null reference exception
        //    if (restOfTheNumbers != null)
        //    {
        //        foreach (int i in restOfTheNumbers)
        //        {
        //            result += i;
        //        }
        //    }

        //    Console.WriteLine("Total = " + result.ToString());
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_StaticMember
{
    class Circle
    {
        static float _pi = 3.14F;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }
        public float Area()
        {
            return Circle._pi * this._radius * this._radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(3);
            float Area = c1.Area();
            Console.WriteLine("Area is: {0}", Area);

            Circle c2 = new Circle(4);
            float Area1 = c2.Area();
            Console.WriteLine("Area is: {0}", Area1);

            
            Console.ReadLine();
        }
    }
}

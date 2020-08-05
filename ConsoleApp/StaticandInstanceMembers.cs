using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class StaticandInstanceMembers
    {
        public static void main()
        {
            Circle c1 = new Circle(5);
            float area = 0F;
            area = c1.CalculateArea();
            Console.WriteLine("Area = {0}", area);
        }
    }


    class Circle
    {
        //State of the class
        static float _PI;  //here the value of pi field is always constant so we can make it static
        //static fields only occupy one location in the memory
        int _radius = 0;

        //Static Constructor
        //It cannot have access modifiers because it shouldn't be called by outside objects
        //Static constructor is only called once,   it is called before instance constructors
        static Circle()
        {
            Circle._PI = 3.141F;
        }

        //Instance constructor
        //Instanct constructor is only called every time an instance of the class is created
        public Circle(int radius)
        {
            this._radius = radius;
        }

        //Behaviour of the class
        public float CalculateArea()
        {
            return Circle._PI * this._radius * this._radius;
        }
    }
}

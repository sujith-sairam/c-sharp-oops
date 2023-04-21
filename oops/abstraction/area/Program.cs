using System;

namespace Calculation{

    abstract class Shape{

        public abstract void RectangleArea(double length,double breadth);

        public abstract void SquareArea(double side);

        public abstract void CircleArea(double radius); 
    }

    class Area : Shape {

        public override void CircleArea(double radius)
        {
            double result = 3.14 * radius * radius;
            Console.WriteLine("The Area of the circle is : {0}",result);
        }

        public override void RectangleArea(double length, double breadth)
        {
            double result = length * breadth;
            Console.WriteLine("The Area of Rectangle is {0}",result);
        }

        public override void SquareArea(double side)
        {
            double result = side * side;
            Console.WriteLine("The Area of Square is {0}",result);
        }
    }

    class MainClass{
        public static void Main(string[] args){
           
           Area shape = new Area();
           shape.CircleArea(2.5);
           shape.RectangleArea(4.5,8);
           shape.SquareArea(9);
        }
    }
}
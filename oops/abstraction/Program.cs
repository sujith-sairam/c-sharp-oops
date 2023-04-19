using System;

namespace Math{
    //Declaring Abstract class for shapes  
     abstract class Shape{
        //abstract methods for shape calculations
        abstract public void Area();

        abstract public void Perimeter();
     }

    //Square class extends from shape
    class Square : Shape {
        private int side;
        //Constructor declaration for square
        public Square(int parameter_side){
            side = parameter_side;
        }
        
        //Abstract methods implementation
        public override void Area(){
            Console.Write("The area of the Square is : {0} \n",side*side);
        }

        public override void Perimeter()
        {
            Console.Write("The Perimeter of the Square is : {0} \n",4*side);
        }
    }

    //Rectangle class that extends shape class
    class Rectangle : Shape{

        private int length;
        private int breadth;
        //Constrctor declaration
        public Rectangle(int parameter_length,int parameter_breadth){

            length = parameter_length;
            breadth = parameter_breadth;
        }

        //Abstract methods implementation
        public override void Area()
        {
            Console.Write("The Area of the Recatangle is : {0} \n",length*breadth);
        }

        public override void Perimeter()
        {
            Console.Write("The Perimeter of the Rectangle is : {0} \n",2*(length + breadth));
        }
    }
    //Declaration of circle that extends shape class
    class Circle : Shape{
        private double radius;
        //constructor for circle
        public Circle(double parameter_radius){

            radius = parameter_radius;
        }
        //Abstract Method implementation
        public override void Area()
        {
            Console.Write("The Area of Circle is : {0} \n",(22/7)*radius*radius );
        }

        public override void Perimeter()
        {
            Console.Write("The Perimeter of Circle is : {0}",2*(22/7)*radius);
        }

    }
    class MainClass{
        public static void Main(string[] args){

           Square square = new Square(5);
           square.Area();
           square.Perimeter();

           Rectangle rectangle = new Rectangle(5,6);
           rectangle.Area();
           rectangle.Perimeter();

           Circle circle = new Circle(3.5);
           circle.Area();
           circle.Perimeter();
        }
    }
}
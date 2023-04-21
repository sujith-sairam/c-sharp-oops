using System;

namespace Math{
    //Declaring Abstract class for shapes  
     abstract class Shape{
        //abstract methods for perimeter calculations
        public abstract Double calculatePerimeter(); 
 


    //Square class extends from shape
    class Square : Shape {
        private float side;
        
        //Abstract method implementation
        public override double calculatePerimeter()
        {
            Console.WriteLine("Enter the side of the Square: ");
            this.side = Convert.ToSingle(Console.ReadLine());
            double result = side * 4;
            return result;
        }
    }

    //Rectangle class that extends shape class
    class Rectangle : Shape{

        private float length;
        private float breadth;
       

        //Abstract methods implementation

        public override double calculatePerimeter()
        {
            Console.Write("Enter the length of the Rectangle: ");
            this.length = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the breadth of the Rectangle: ");
            this.breadth = Convert.ToSingle(Console.ReadLine());
            double result = 2*(length + breadth);
            return result;


        }
    }
    //Declaration of circle that extends shape class
    class Circle : Shape{
        private float radius;
        
        //Abstract Method implementation
        public override double calculatePerimeter()
        {
            Console.WriteLine("Enter the Radius of the Circle :");
            this.radius = Convert.ToSingle(Console.ReadLine());
            double result = 2 * 3.14 * radius;
            return result;
        }

    }
    class MainClass{
        public static void Main(string[] args){

            Console.WriteLine("List of Shapes :");
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Square");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            Shape circle = new Circle();
            Shape rectangle = new Rectangle();
            Shape square = new Square();

            switch(choice){
                case 1:
                    double circle_result = circle.calculatePerimeter();
                    Console.WriteLine("The perimeter is : {0}",circle_result);
                    break;
                
                case 2:
                    double rectangle_result = rectangle.calculatePerimeter();
                    Console.WriteLine("The perimeter is : {0}",rectangle_result);
                    break;

                case 3:
                   double square_result =  square.calculatePerimeter();
                   Console.WriteLine("The perimeter is : {0}",square_result);
                   break;

                default:
                    Console.WriteLine("Enter the right option:");
                    break;

            }
           
        }
    }
}
}
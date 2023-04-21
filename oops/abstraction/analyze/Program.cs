using System;

namespace Analyze{

    //Base class 
    abstract class Base{

        //Constructor of base class
        public Base(){
            Console.WriteLine("This is an constructor of abstract class");
        }

        //defined abstract method
        public abstract void a_method();

        //Normal method of base class
        public void normalMethod(){
            Console.WriteLine("This is an normal method of abstract class");
        }
    }

    //Derived class inherits from Base class 
    class Derived : Base{

        //Override method of abstract class
        public override void a_method()
        {
            Console.WriteLine("This is abstract method");
        }
    }

    class MainClass{

        public static void Main(string[] args){

            Derived subClass = new Derived();
            subClass.a_method();
            subClass.normalMethod();
        }
    }
}
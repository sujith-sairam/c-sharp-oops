using System;

namespace Heirarchy{
//Abstract class 
abstract class Parent{
    //Abstract method
   public abstract void message();
}

//First class inherits abstract class
class First : Parent{

    //overrides abstract method from base class
    public override void message(){
        Console.WriteLine("This is first subclass");
    }
}

//First class inherits abstract class
class Second : Parent{

    //overrides abstract method from base class
    public override void message(){
        Console.WriteLine("This is second subclass");
    }
}

class MainClass{ 

    public static void Main(string[] args){

        First elderSon = new First();
        elderSon.message();

        Second youngerSon = new Second();
        youngerSon.message();
    }
}

}
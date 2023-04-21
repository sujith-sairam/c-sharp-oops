using System;

namespace Identifier{

    abstract class Animals{

        //abstract method for cats
        public abstract void cats();

        //absract method for dogs
        public abstract void dogs(); 
    }

    //Cat inherits Animals class
    class Cat : Animals{
        //override methods 
        public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }

        public override void dogs()
        {
            Console.WriteLine("Call cats for implementation!!!!! ");
        }
    }

    //Dog inherits Animals class
    class Dog : Animals{
        //override methods
        public override void dogs()
        {
            Console.WriteLine("Dogs Bark");
        }

        public override void cats()
        {
            Console.WriteLine("Call dogs for implementation!!!!! ");
        }
    }

    class MainClass{
        public static void Main(string[] args){

            Cat kitten = new Cat();
            kitten.cats();

            Dog puppy = new Dog();
            puppy.dogs();
        }
    }
}
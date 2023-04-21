using System;

namespace BankAccount{
    //Abstract class and base class
    abstract class Bank{
        //abstract method
        public abstract void getBalance(); 
    }

    //BankA inherits abstract Bank class
    class BankA : Bank{
        private int deposited = 100;
        //overide method of abstract method from base class
        public override void getBalance()
        {
           Console.WriteLine(deposited);
        }

    }

    //BankB inherits abstract Bank class 
     class BankB : Bank{
        private int deposited = 150;
        //overide method of abstract method from base class
        public override void getBalance()
        {
           Console.WriteLine(deposited);
        }

    }

    //BankC inherits abstract Bank class
     class BankC : Bank{
        private int deposited = 200;
        //overide method of abstract method from base class
        public override void getBalance()
        {
           Console.WriteLine(deposited);
        }

    }

    class MainClass{
        public static void Main(string[] args){

            BankA savingsAccount_A = new BankA();
            savingsAccount_A.getBalance();

            BankB savingsAccount_B = new BankB();
            savingsAccount_B.getBalance();

            BankC savingsAccount_C = new BankC();
            savingsAccount_C.getBalance();
        }
    }
}
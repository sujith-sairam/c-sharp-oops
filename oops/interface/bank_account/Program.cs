using System;

namespace BankAccounts{
    //Base class for bank accounts
    interface IAccount{
      
         void Intrest();
         void Deposit(double amount);

    }

    //DepositAccount implements Interface IAccount
    class DepositAccount : IAccount{

        private double intrestRate = 0.09;
        private double amount = 0; 
        private int months = 0;
        
        //constructor for initializing the amount and months
        public DepositAccount(double amount ,int months){

            this.amount = amount;
            this.months = months;

        }
        //Returns Intrest of the principal amount
        public void Intrest()
        {
            if(amount < 1000){
                Console.WriteLine(0);
            }else{
                Console.WriteLine("Intrest Amount : {0}",(amount * intrestRate * months)/12);
            }
        }

        //Deposit method for adding amount to the account..
        public void Deposit(double Amount){
            this.amount += Amount;
            Console.WriteLine("The Amount of Rs{0} has been deposited successfully",Amount);
        }
        
        //Method for amount withdrawal
        public void WithDrawAmount(double withDrawAmount)
        {
            amount = amount - withDrawAmount;
            Console.WriteLine("Amount of Rs {0} has been taken successfully ",withDrawAmount);

        }
    }

    //LoanAccount implements Interface Account
    class LoanAccount : IAccount{
        private double amount = 0;
        private int months = 0;
        private double intrestRate = 0.085;
        private double intrestAmount = 0;

        //LoanAccount Constructor for initialzation
        public LoanAccount(string type,double amount,int months){
            this.amount = amount;
            this.months = months;
            if(type == "company"){
                this.intrestAmount = (amount * intrestRate * months-2)/12;
            }else{
                this.intrestAmount = (amount * intrestRate * months-3)/12;
            }
        }

        //Deposit method for paying the loan amount
        public void Deposit(double Amount){
            this.amount -= Amount; 
            Console.WriteLine("Amount of Rs{0} has been deposited successfully",Amount);
        }
        //Intrest method that returns intrest amount
        public void Intrest(){

            Console.WriteLine("Intrest amount: {0}",intrestAmount);
        }
    }

    class MortageAccount : IAccount {
        private double amount;
        private int years;
        private double intrestRate = 0.85;
        private double intrestAmount = 0;

        public MortageAccount(string type,double amount,int year){
            this.years = year;
            this.amount = amount;
            if(type == "company"){
                this.intrestRate = 0.05;
                intrestAmount = (amount * intrestRate * years)/12;
            }else{
                intrestAmount = (amount * intrestRate * years)/12;
            }
        }

        //Amount has been deposited successfully
        public  void Deposit(double Amount){
            this.amount -= Amount;
            Console.WriteLine("Amount of Rs{0} has been deposited successfully",Amount);
        }

        //Intrest method that returns intrest amount
        public void Intrest(){

            Console.WriteLine("Intrest Amount: {0}",Math.Round(intrestAmount,2));
        }

    }

    class MainClass{
        public static void Main(string[] args){
            DepositAccount David = new DepositAccount(10000,12);
            David.Intrest();
            David.WithDrawAmount(1000);

            LoanAccount Anil = new LoanAccount("individual",400000,24);
            Anil.Intrest();
            Anil.Deposit(20000);

            LoanAccount HoneyWell = new LoanAccount("company",800000,36);
            Anil.Intrest();
            Anil.Deposit(40000);

            MortageAccount OrientBell = new MortageAccount("company",3000000,10);
            OrientBell.Intrest();
            OrientBell.Deposit(9000);

            MortageAccount Jack = new MortageAccount("individual",400000,10);
            Jack.Intrest();
            Jack.Deposit(9000);
        }
    }
}
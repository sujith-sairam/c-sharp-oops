namespace Bank{

    //Bank_Account class
    class BankAccount{
        private string name="";
        private int account_number;
        private int pin;
        private static int balance=0;

        //getter and setter for private fields
        public string Name{
            get{ return name;}
            set{ name = value;}
        }

        public int Account_Number{
            get{return account_number;}
            set{account_number=value;}
        }

        public int Pin{
            get{return pin;}
            set{ pin=value;}
        }

        public int Balance{
            get{return balance;}
            set{ balance=value;}
        }

        //Constructor for object creation
        public BankAccount(string Name,int Account_Number,int Pin){
            this.Name = Name;
            this.Account_Number = Account_Number;
            this.Pin = Pin;
        }

        // Method for adding amount 
        public void deposit(int amount){
            this.Balance += amount;
            Console.WriteLine("The amount has been deposited successfully");
        }

        //Method for checking balance
        public void check_balance(){
            Console.WriteLine("Balance : " + Balance);
        }

        //Method for amount withdraw
        public void withdraw_amount(int amount){
            if(Balance == 0){
                Console.WriteLine("Insufficient Balance");
            }else{
                Balance = Balance - amount;
                Console.WriteLine("Withdraw Successful");
            }
        }
    }

    class MainClass{

        public static void Main(string[] args){
            
            BankAccount bank_account = new BankAccount("sujith",1234567890,1233);
            bank_account.deposit(1000);
            bank_account.withdraw_amount(500);
            bank_account.check_balance();
        }
    }
}
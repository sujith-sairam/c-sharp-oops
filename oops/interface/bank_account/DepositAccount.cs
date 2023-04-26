namespace BankAccounts{

    //DepositAccount implements Interface IAccount
    class DepositAccount : IAccount{
        private string accountHolderName;
        private double intrestRate = 0.09;
        private long totalAmount = 0; 
        private int totalMonths = 0;
        
        //constructor for initializing the amount and months
        public DepositAccount(string name,long amount ,int months){
            this.accountHolderName = name;
            this.totalAmount = amount;
            this.totalMonths = months;

        }
        //Returns Intrest of the principal amount
        public void Intrest()
        {
            if(totalAmount < 1000){
                Console.WriteLine(0);
            }else{
                Console.WriteLine("Intrest Amount : {0}",(totalAmount * intrestRate * totalMonths)/12);
            }
        }

        //Deposit method for adding amount to the account..
        public void Deposit(long Amount){
            this.totalAmount += Amount;
            Console.WriteLine("The Amount of Rs{0} has been deposited successfully",Amount);
        }
        
        //Method for amount withdrawal
        public void WithDrawAmount(long withDrawAmount)
        {
            totalAmount = totalAmount - withDrawAmount;
            Console.WriteLine("Amount of Rs {0} has been taken successfully ",withDrawAmount);

        }

        public void Balance(){

            Console.WriteLine("Balance: {0}",totalAmount);
        }
    }
}
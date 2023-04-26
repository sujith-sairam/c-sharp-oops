namespace BankAccounts{
    //Base class for bank accounts
    interface IAccount{
      
         void Intrest();
         void Deposit(long amount);

         void Balance();

    }
}
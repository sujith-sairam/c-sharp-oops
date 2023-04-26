
namespace BankAccounts{
  
   //LoanAccount implements Interface Account
    class LoanAccount : IAccount{
        private string accountHolderName;
        private long totalAmount = 0;
        private int totalMonths = 0;
        private double intrestRate = 5;
        private double intrestAmount = 0;

        //LoanAccount Constructor for initialzation
        public LoanAccount(string name,string type,long amount,int months){

            this.accountHolderName = name;
            this.totalAmount = amount;
            this.totalMonths = months;
            if(type == "company"){
                double totalIntrestAmount =  (totalAmount * intrestRate * totalMonths/12)/100 ;
                this.intrestAmount = Math.Round(totalIntrestAmount - 2*(totalIntrestAmount/12),2);
            }else{
                double totalIntrestAmount = (totalAmount * intrestRate * totalMonths/12)/100 ;
                this.intrestAmount = Math.Round(totalIntrestAmount - 3*(totalIntrestAmount/12),2);
            }
        }

        //Deposit method for paying the loan amount
        public void Deposit(long Amount){
            this.totalAmount -= Amount; 
            Console.WriteLine("Amount of Rs{0} has been deposited successfully",Amount);
        }
        //Intrest method that returns intrest amount
        public void Intrest(){

            Console.WriteLine("Intrest amount: {0}",intrestAmount);
        }

        public void Balance(){

            Console.WriteLine("Balance: {0}",this.totalAmount);
        }
    }
       
    }
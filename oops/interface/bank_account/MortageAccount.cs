namespace BankAccounts{
    
    class MortageAccount : IAccount {

        private string type;
        private string accountHolderName;
        private long totalAmount;
        private int totalMonths;
        private double intrestRate = 6;
        private double intrestAmount;

        public MortageAccount(string type,string name,long amount,int months){

            this.type = type;
            this.accountHolderName = name;
            this.totalMonths = months;
            this.totalAmount = amount;
            if(type == "company"){
                double totalIntrestAmount =  (totalAmount * 5 * 12/12)/100 + (totalAmount * intrestRate * (totalMonths-12)/12)/100 ;
                this.intrestAmount = totalIntrestAmount;
            }else{
                this.intrestRate = 6;
                intrestAmount =  (totalAmount * intrestRate * (totalMonths - 6)/12)/100   ;
            }
        }

        //Amount has been deposited successfully
        public  void Deposit(long Amount){
            this.totalAmount -= Amount;
            Console.WriteLine("Amount of Rs{0} has been deposited successfully",Amount);
        }

        //Intrest method that returns intrest amount
        public void Intrest(){

            Console.WriteLine("Intrest Amount: {0}",intrestAmount);
        }

        public void Balance(){

            Console.WriteLine("Balance: {0}",totalAmount);
        }

    } 
}
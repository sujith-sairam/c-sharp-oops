using System;

namespace BankAccounts{
    class MainClass{
        public static void Main(string[] args){

            Console.WriteLine(" Enter the type of account: \n 1.Deposit Account\n 2.Loan Account \n 3.Mortage Account");
            int type = Convert.ToInt32(Console.ReadLine());
            switch(type){
                case 1:
                    Console.WriteLine(" Enter Your Name : ");
                    string depositAccountName = Console.ReadLine(); 
                    Console.WriteLine(" Enter the amount :");
                    long depostAccountAmount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter the total months : ");
                    int depositAccountMonths = Convert.ToInt32(Console.ReadLine());
                    DepositAccount depositAccountHolder = new DepositAccount(depositAccountName,depostAccountAmount,depositAccountMonths);
                    deposit_repeat:
                    Console.WriteLine(" Enter the option :");
                    Console.WriteLine(" 1.Check Balance \n 2.Show Intrest Amount \n 3.Deposit Amount \n 4.Withdraw Amount ");
                    int depositOption = Convert.ToInt32(Console.ReadLine());
                    switch(depositOption){
                        case 1:
                            depositAccountHolder.Balance();
                            Console.WriteLine("If you want to continue press enter:");
                            var balanceInputValue = Console.ReadKey();
                            if(balanceInputValue.Key == ConsoleKey.Enter){
                                goto deposit_repeat;
                            }else{ 
                                break;
                            }
                        case 2:
                            depositAccountHolder.Intrest();
                            Console.WriteLine(" If you want to continue press enter:");
                            var intrestInputValue= Console.ReadKey();
                            if(intrestInputValue.Key == ConsoleKey.Enter){
                                goto deposit_repeat;
                            }else{ 
                                break;
                            }
                         case 3:
                            Console.WriteLine(" Enter the amount for deposit: ");
                            long depositAmount = Convert.ToInt64(Console.ReadLine());
                            depositAccountHolder.Deposit(depositAmount);
                            Console.WriteLine("If you want to continue press enter:");
                            var depositInputValue= Console.ReadKey();
                            if(depositInputValue.Key == ConsoleKey.Enter){
                                goto deposit_repeat;
                            }else{ 
                                break;
                            }
                         case 4:
                            Console.WriteLine(" Enter the amount to withdraw : ");
                            long withdrawAmount = Convert.ToInt64(Console.ReadLine());
                            depositAccountHolder.WithDrawAmount(withdrawAmount);
                            Console.WriteLine("If you want to continue press enter:");
                            var withdrawInputValue= Console.ReadKey();
                            if(withdrawInputValue.Key == ConsoleKey.Enter){
                                goto deposit_repeat;
                            }else{ 
                                break;
                            }
                            }
                            break;
                    case 2:
                        Console.WriteLine(" Enter your account type: ");
                        string loanAccountType = Console.ReadLine();
                        Console.WriteLine(" Enter Your Name : ");
                        string loanAccountName = Console.ReadLine(); 
                        Console.WriteLine(" Enter the amount :");
                        long loanAccountAmount = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine(" Enter the total months : ");
                        int loanAccountMonths = Convert.ToInt32(Console.ReadLine());
                        LoanAccount loanAccountHolder = new LoanAccount(loanAccountName,loanAccountType,loanAccountAmount,loanAccountMonths);
                        repeat:
                        Console.WriteLine(" Enter the option :");
                        Console.WriteLine(" 1.Check Balance \n 2.Show Intrest Amount \n 3.Deposit Amount ");
                        int loanOption = Convert.ToInt32(Console.ReadLine());
                        switch(loanOption){
                            case 1:
                                loanAccountHolder.Balance();
                                Console.WriteLine("If you want to continue press enter:");
                                var balanceInputValue = Console.ReadKey();
                                if(balanceInputValue.Key == ConsoleKey.Enter){
                                    goto repeat;
                                }else{ 
                                    break;
                                }
                            case 2:
                                loanAccountHolder.Intrest();
                                Console.WriteLine("If you want to continue press enter:");
                                var intrestInputValue= Console.ReadKey();
                                if(intrestInputValue.Key == ConsoleKey.Enter){
                                    goto repeat;
                                }else{ 
                                    break;
                                }
                            case 3:
                                Console.WriteLine("Enter the amount for deposit: ");
                                long depositAmount = Convert.ToInt64(Console.ReadLine());
                                loanAccountHolder.Deposit(depositAmount);
                                Console.WriteLine("If you want to continue press enter:");
                                var depositInputValue= Console.ReadKey();
                                if(depositInputValue.Key == ConsoleKey.Enter){
                                    goto repeat;
                                }else{ 
                                    break;
                                }
                        }
                        break;
                    case 3:
                        Console.WriteLine(" Enter your account type: ");
                        string mortageAccountType = Console.ReadLine();
                        Console.WriteLine(" Enter Your Name : ");
                        string mortageAccountName = Console.ReadLine(); 
                        Console.WriteLine(" Enter the amount :");
                        long mortageAccountAmount = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine(" Enter the total months : ");
                        int mortageAccountMonths = Convert.ToInt32(Console.ReadLine());
                        MortageAccount mortageAccountHolder = new MortageAccount(mortageAccountType,mortageAccountName,mortageAccountAmount,mortageAccountMonths);
                        mortage_repeat:
                        Console.WriteLine(" Enter the option :");
                        Console.WriteLine(" 1.Check Balance \n 2.Show Intrest Amount \n 3.Deposit Amount ");
                        int mortageOption = Convert.ToInt32(Console.ReadLine());
                        switch(mortageOption){
                            case 1:
                                mortageAccountHolder.Balance();
                                Console.WriteLine("If you want to continue press enter:");
                                var balanceInputValue = Console.ReadKey();
                                if(balanceInputValue.Key == ConsoleKey.Enter){
                                    goto mortage_repeat;
                                }else{ 
                                    break;
                                }
                            case 2:
                                mortageAccountHolder.Intrest();
                                Console.WriteLine("If you want to continue press enter:");
                                var intrestInputValue= Console.ReadKey();
                                if(intrestInputValue.Key == ConsoleKey.Enter){
                                    goto mortage_repeat;
                                }else{ 
                                    break;
                                }
                            case 3:
                                Console.WriteLine("Enter the amount for deposit: ");
                                long depositAmount = Convert.ToInt64(Console.ReadLine());
                                mortageAccountHolder.Deposit(depositAmount);
                                Console.WriteLine("If you want to continue press enter:");
                                var depositInputValue= Console.ReadKey();
                                if(depositInputValue.Key == ConsoleKey.Enter){
                                    goto mortage_repeat;
                                }else{ 
                                    break;
                                }
                            
                        }
                        break;



            }


            
        }
    }
}
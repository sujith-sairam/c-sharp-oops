using System;

namespace Market{
    interface IStall{
        //interface method declaration
         void Display();
    }

    //class GoldStall implements IStall
    class GoldStall : IStall{
        private string stallName;
        private int cost;
        private string ownerName;
        private int tvSet;

        public GoldStall(string name,int price,string owner,int count){
            this.stallName = name;
            this.cost = price;
            this.ownerName = owner;
            this.tvSet = count;
        }
        public  void Display(){
            Console.WriteLine("Stall Name: {0}\nCost: Rs{1}\nOwner Name: {2}\nNumber of TV sets: {3}\n",stallName,cost,ownerName,tvSet);
        }
    }

    //class PremiumStall implements IStall
    class PremiumStall : IStall{
        private string stallName;
        private int cost;
        private string ownerName;
        private int projector;

        public PremiumStall(string name,int price,string owner,int count){
            this.stallName = name;
            this.cost = price;
            this.ownerName = owner;
            this.projector = count;
        }
        public  void Display(){
            Console.WriteLine("Stall Name: {0}\nCost: Rs{1}\nOwner Name: {2}\nNumber of Projectors: {3}\n",stallName,cost,ownerName,projector);
        }
    }

    //class ExecutiveStall implements IStall
    class ExecutiveStall : IStall{
        private string stallName;
        private int cost;
        private string ownerName;
        private int screen;

        public ExecutiveStall(string name,int price,string owner,int count){
            this.stallName = name;
            this.cost = price;
            this.ownerName = owner;
            this.screen = count;
        }
        public  void Display(){
            Console.WriteLine("Stall Name: {0}\nCost: {1}\nOwner Name: {2}\nNumber of Screens: {3}",stallName,cost,ownerName,screen);
        }
    }

    class MainClass{
        public static void Main(string[] args){
            Console.Write("Choose Stall Type \n 1)Gold Stall \n 2)Premium Stall \n 3)Executive Stall\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,StallCost,OwnerName,Number of TV sets)");
                    string inputGold = Console.ReadLine();
                    string[] inputArrayGold = inputGold.Split(',');
                    string name = inputArrayGold[0];
                    int cost = int.Parse(inputArrayGold[1]);
                    string owner = inputArrayGold[2];
                    int count = int.Parse(inputArrayGold[3]);
                    GoldStall goldStall = new GoldStall(name,cost,owner,count);
                    goldStall.Display();
                    break;
                case 2:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,StallCost,OwnerName,Number of Projectors)");
                    string inputPremium = Console.ReadLine();
                    string[] inputArrayPremium = inputPremium.Split(',');
                    string namePremium = inputArrayPremium[0];
                    int costPremium = int.Parse(inputArrayPremium[1]);
                    string ownerPremium = inputArrayPremium[2];
                    int countPremium = int.Parse(inputArrayPremium[3]);
                    PremiumStall premiumStall = new PremiumStall(namePremium,costPremium,ownerPremium,countPremium );
                    premiumStall.Display();
                    break;
                case 3:
                    Console.WriteLine("Enter Stall details in comma separated(Stall Name,StallCost,OwnerName,Number of Projectors)");
                    string inputExecutive = Console.ReadLine();
                    string[] inputArrayExecutive = inputExecutive.Split(',');
                    string nameExecutive = inputArrayExecutive[0];
                    int costExecutive = int.Parse(inputArrayExecutive[1]);
                    string ownerExecutive = inputArrayExecutive[2];
                    int countExecutive = int.Parse(inputArrayExecutive[3]);
                    ExecutiveStall executiveStall = new ExecutiveStall(nameExecutive,costExecutive,ownerExecutive,countExecutive );
                    executiveStall.Display();
                    break;
                default:
                    Console.WriteLine("Enter the right option:");
                    break;
            }
        }
    }
}
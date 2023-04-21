using System;

namespace Percentage{

    abstract class Marks{

        public abstract void getPercentage();
    }
    //StudentA inherits from base class Marks 
    class StudentA : Marks{
        private int mark_1;
        private int mark_2;
        private int mark_3;

        public StudentA(int subject_1,int subject_2,int subject_3){
            this.mark_1 = subject_1;
            this.mark_2 = subject_2;
            this.mark_3 = subject_3;
        }

        //overrides abstract method from base class
        public override void getPercentage()
        {
            int total = this.mark_1 + this.mark_2 + this.mark_3;
            double percentage = Math.Round((total/3.0D),2);
            Console.WriteLine(percentage);
        }
    }

    //StudentB inherits from base class Marks 
    class StudentB : Marks{
        private int mark_1;
        private int mark_2;
        private int mark_3;
        private int mark_4;

        public StudentB(int subject_1,int subject_2,int subject_3,int subject_4){
            this.mark_1 = subject_1;
            this.mark_2 = subject_2;
            this.mark_3 = subject_3;
            this.mark_4 = subject_4;
        }

        //overrides abstract method from base class
        public override void getPercentage()
        {
            double percentage = Math.Round((mark_1 + mark_2 + mark_3 + mark_4)/4.0,2);
            Console.WriteLine(percentage);
        }
    }

    class MainClass{

        public static void Main(string[] args){
             
             StudentA Jack = new StudentA(89,90,99);
             Jack.getPercentage();

            StudentB David = new StudentB(90,92,93,94);
            David.getPercentage();
        }
    }
}

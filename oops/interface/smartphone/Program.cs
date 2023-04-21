using System;

namespace Device{
    //Contact interface with call and decline methods
    interface IContact{

        void Call();
        void Decline();
    }
    //Camera inteface with capture and record methods
    interface ICamera{

        void Capture();
        void Record();
    }
    //Player interface with play and stop methods
    interface IPlayer{

        void Play();
        void Stop();
    }

    class SmartPhone :ICamera,IContact,IPlayer {
        //Implementation of call method
        public void Call(){
            Console.WriteLine("Calling the contact...");
        }
        //Implementation of decline method
        public void Decline(){
            Console.WriteLine("Declining the call...");
        }
        //Implementation of capture method
        public void Capture(){
            Console.WriteLine("Camera is capturing the image...");
        }
        //Implementation of record method
         public void Record(){
            Console.WriteLine("Camera has started the Recording...");
        }
        //Implementation of play method
        public void Play(){
            Console.WriteLine("The music has been started...");
        }
        //Implementation of stop method
        public void Stop(){
            Console.WriteLine("The music has been stopped...");
        }

    }

    class MainClass{
        public static void Main(string[] args){
            
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Call();
            smartPhone.Decline();
            smartPhone.Capture();
            smartPhone.Record();
            smartPhone.Play();
            smartPhone.Stop();

        }
    }
}
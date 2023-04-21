using System;

namespace FourWheelers{

//base class declaration
class Vehicle{
    private string make="";
    private string model="";
    private int year;
    private string color="";

    public  string Make{ 
        get {return make;}
        set {make = value;}
        }
    public  string Model{ 
        get {return model;}
        set {model = value;}
        }

    public int Year{ 
        get {return year;}
        set {year = value;}
        }

    public  string Color{ 
        get {return color;}
        set {color = value;}
        }

    public Vehicle(string make,string model,int year,string color){
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.Color = color;
    }
     public void start_engine(){
        Console.WriteLine($"The engine has been started...\nBrand:{Make}\nModel:{Model}\nYear:{Year}");
    }
}
    // Inheriting Car class from Vehicle
    class Car : Vehicle{
       private int num_doors;
       public Car(string Make,string Model,int Year,string Color,int num_doors) : base(Make,Model,Year,Color){
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Color = Color;
        this.num_doors = num_doors;
       }


// Inheriting Truck class from Vehicle
  class Truck : Vehicle{
       private int payload_capacity;
       public Truck(string Make,string Model,int Year,string Color,int payload_capacity) : base(Make,Model,Year,Color){
        this.Make = Make;
        this.Model = Model;
        this.Year = Year;
        this.Color = Color;
        this.payload_capacity = payload_capacity;
       }

    
}
class MainClass{
    public static void Main(string[] args){
        //Creating object for car
       

       Vehicle v = new Vehicle("eicher","hkwdqbd",2352,"red");
       v.start_engine();
    }
}

}
}
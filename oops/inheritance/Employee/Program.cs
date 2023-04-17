/*Create a class called Employee with attributes name, id, and salary.Then, 
create two subclasses called Manager and Engineer that add attributes specific to each role,such
as department for Manager and language for Engineer. Make sure that the Employee class has a 
method calculate_salary() that can be overridden by the subclasses to calculate the employee's total salary.*/


namespace Inheritance{
//base class declaration
class Employee{
    public string name;
    public int id;
    protected double salary;
    public double Salary{
        get{ return salary; }
        set { salary = value;}
    }
     public Employee(string name,int id,double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    //base salary method for employee
    public void calculate_salary(){
        Console.WriteLine(salary);
    }
}

//Manager class inheriting Employee
class Manager : Employee{
    public string department;
    public Manager(string name,int id,double salary,string department) : base(name,id,salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
        this.department = department;
    }

    //salary method for manager
     public void calculate_salary(double manager_salary){
        Console.WriteLine(manager_salary);
    }
}

//Engineer class inheriting Employee 
class Engineer : Employee{
    public string language;
    public Engineer(string name,int id,double salary,string language) : base(name,id,salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
        this.language = language;
    }

    //salary method for engineer
     public void calculate_salary(double engineer_salary){
        Console.WriteLine(engineer_salary);
    }
}
class MainClass{
    static void Main(string[] args) {
    
    //creating object for Manager
    Manager manager = new Manager("Shyam",23,100000,"Sales");
    manager.calculate_salary(manager.Salary);

    //creating object for Enginner   
    Engineer engineer = new Engineer("Raghu",12,50000,"python");
    engineer.calculate_salary(engineer.Salary);
    }
}

}
namespace School{

    //Student class declaration 
    class Student{
        private string name="";
        private int standard;
        private string place="";
        private string password="";

        public string Name{
            get{ return name;}
            set{name=value;}
        }

        public int Standard{
            get{ return standard;}
            set{standard=value;}
        }

        public string Place{
            get{ return place;}
            set{place=value;}
        }

        public string Password{
            get{ return password;}
            set{password=value;}
        }

        //Constructor for creating student object
        public Student(string Name,int Standard,string Place,string Password){
            this.Name = Name;
            this.Standard = Standard;
            this.Place = Place;
            this.Password = Password;
        }

        //Method for displaying student's details
        public void display_details(){
            Console.WriteLine("Name:"+Name+"\n"+"Standard:"+Standard+"\n"+"Place:"+Place);
        }

        //method for login 
        public void login(string password){
            if(password == Password){
                Console.WriteLine("Login successfull");
            }else{
                Console.WriteLine("Login Failed");
            }
        }

        //Method to change the password
        public void reset_password(string password){
           this.Password = password;
           Console.WriteLine("password has been changed successfully");
        }
}
    class MainClass{
        public static void Main(string[] args){
            Student s = new Student("Kiran",8,"cbe","112233");
            s.display_details();
            s.login("112233");
            s.reset_password("1122");
        }
    }
}
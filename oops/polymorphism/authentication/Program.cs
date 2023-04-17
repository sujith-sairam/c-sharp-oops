namespace Authentication{

    //User base class declaration
    class User{
        //User login method
        public virtual void login(string user_name,string password,string role){
            if(role == "user" && (user_name == "user" && password == "User@123")){
                Console.WriteLine("User has been logged in successfully");
            }else{
                Console.WriteLine("Invalid User Login");
            }
        }
    }

    //Admin class derived from User class
     class Admin : User{
        //Admin login method
        public override void login(string user_name,string password,string role){
            if(role == "admin" && (user_name == "admin" && password == "Admin@123")){
                Console.WriteLine("Admin has been logged in successfully");
            }else{
                Console.WriteLine("Invalid Admin Login");
            }
        }
    }

    //SuperAdmin class derived from User class
     class SuperAdmin : User{
        //SuperAdmin login method
        public override void login(string user_name,string password,string role){
            if(role == "super_admin" && (user_name == "super_admin" && password == "SuperAdmin@123")){
                Console.WriteLine("SuperAdmin has been logged in successfully");
            }else{
                Console.WriteLine("Invalid SuperAdmin Login");
            }
        }
    }
    class MainClass{
        public static void Main(string[] args){

            User user = new User();
            user.login("user","User@123","user");
            user = new Admin();
            user.login("admin","Admin@123","admin");
            user = new SuperAdmin();
            user.login("super_admin","SuperAdmin@123","super_admin");
            
        }
    }
}
namespace SmartPhone{

    class Contact{

        //creating contact with only mobile number 
        public void create_contact(long mobile_number){
            Console.WriteLine("Contact Name: Contact");
            Console.WriteLine("Number: " + mobile_number);
        }

        //creating contact with  mobile number and contact name
        public void create_contact(string contact_name,long mobile_number){
            Console.WriteLine("Contact Name: "+ contact_name);
            Console.WriteLine("Number: " + mobile_number);
        }

        //creating contact with contact name and two mobile numbers 
        public void create_contact(string contact_name,long mobile_number1,long mobile_number2){
            Console.WriteLine("Contact Name: " + contact_name);
            Console.WriteLine("Number: " + mobile_number1 + " ," + mobile_number2);
        }
    }

    class MainClass{
        public static void Main(string[] args){

            Contact contact = new Contact();
            contact.create_contact(9876543210);
            contact.create_contact("kiran",9876543210);
            contact.create_contact("kiran",9876543210,1234567890);


        }
    }
}
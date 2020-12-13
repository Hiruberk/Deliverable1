using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args) { 
        //Intializing the requirement check variables along with user input variable and the boolean condition
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        int minlength = 7;
        int maxlength = 12;
        string exclamation = "!";
        string password;
        bool valid = false;
        //Intializes the loop to iterate until it meets requirements.
            while(!valid)
            {
            // Describes requirements and asks for input.
            Console.WriteLine("Please enter a Password: \n\n"+ 
                
                "The password must contain the following requirements:\n"+ 
                "At least one lowercase letter.\n" + 
                "At least one uppercase letter.\n" + 
                "At least minimum 7 characters.\n" + 
                "At least maximum 12 Characters.\n" + 
                "An exclamation point: !");
            password = Console.ReadLine();
            // Setting up the first requirement, contains upper case
                if (password.Contains(uppercase) && password.Contains(lowercase) && password.Contains(exclamation)) {;
                           //Setting up the fourth requirement, max length
                            if (password.Length <= maxlength) {;
                                //Setting up the fifth requirement, contains !
                                if (password.Length >= minlength) {
                                    valid = true; /* Breaks the While Loop allowing for accepted password message */
                                    //Outputs for errors
                                } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                            } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                } else { Console.WriteLine("Invalid Password, Please Try Again"); }


            }
            Console.WriteLine("Password valid and accepted");
        }
    }
}

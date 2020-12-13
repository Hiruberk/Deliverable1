using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        //Intializing the requirement check variables along with user input variable and the boolean condition
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        int minlength = 7;
        int maxlength = 12;
        string exclamation = "!";
        string password = password;
        bool valid = false;
          //Intializes the loop to iterate until it meets requirements.
          while (!valid) {
          // Describes requirements and asks for input.
            Console.WriteLine("Please enter a Password: \n\nThe password must contain the following requirements:\nAt least one lowercase letter\nAt least one uppercase letter\nAt least minimum 7 characters\nAt least maximum 12 Characters\nAn exclamation point: !");
            password = Console.ReadLine();
                // Setting up the first requirement, contains upper case
                if (Contains(password, uppercase)) {;
                    // Setting up the second requirement, contains lower case
                    if (Contains(password, lowercase)) {;
                        //Setting up the third requirement, min length
                        if (password.Length >= minlength) {;
                            //Setting up the fourth requirement, max length
                            if (password.Length <= maxlength) {;
                                //Setting up the fifth requirement, contains !
                                if (Contains(password, exclamation)) {;
                                valid = True; /* Breaks the While Loop allowing for accepted password message */
                                //Output if error
                                } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                            } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                        } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                    } else { Console.WriteLine("Invalid Password, Please Try Again"); }
                } else { Console.WriteLine("Invalid Password, Please Try Again"); }

                           
                   }
                Console.WriteLine("Password valid and accepted");
    }
}

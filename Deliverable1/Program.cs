using System;
using System.Text.RegularExpressions;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the requirement check variables along with user input variable
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{7,12}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!]");
            string password;
            // Describes requirements and asks for input.
                Console.WriteLine("Please enter a Password: \n\n" +
                         "The password must contain the following requirements:\n" +
                         "At least one lowercase letter\n" +
                         "At least one uppercase letter\n" +
                         "At least minimum 7 characters\n" +
                         "At least maximum 12 Characters\n" +
                         "An exclamation point: !");
                password = Console.ReadLine();
            // Setting up the first requirement, contains lower case
            if (hasLowerChar.IsMatch(password))
            {// Setting up the second requirement, contains upper case
                if (hasUpperChar.IsMatch(password))
                {// Setting up the third requirement, contains proper length
                    if (hasMiniMaxChars.IsMatch(password))
                    {// Setting up the fourth requirement, contains !
                        if (hasSymbols.IsMatch(password))
                        {// Passes all requirements and outputs password accepatance
                            Console.WriteLine("Password valid and accepted"); 
                         // The failed output statements
                        } else { Console.WriteLine("Error, password must have symbols"); };

                    } else { Console.WriteLine("Error, password must be between 7 & 12 characters"); }

                } else { Console.WriteLine("Error, password must have at least 1 upper case letter"); }

            } else { Console.WriteLine("Error, password must have at least 1 lower case letter"); }

        }
    }
}

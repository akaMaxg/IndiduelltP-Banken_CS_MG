using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class MessagesInformations
    {
        public static void enterToContinue() //Function to press enter to return to main menu
        {
            Console.WriteLine("Press the Enter key to return to the Main menu...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine("You did not press the Enter key. Try again.");
            }
        }
        public static void WelcomeMsg() //function that greets and prompts login
        {
            Console.WriteLine("Welcome to the mock-bank Program!"); //Greetings
            // Prompt the user to log in
            Console.WriteLine("Please log in to continue.");
        }
        public static string PresentableName(User user) //Sets first character of name to Upper case
        {
            string usernameFirst = user.username[0].ToString(); //Extracts first character of name
            usernameFirst = usernameFirst.ToUpper(); //Makes it uppcase
            string capitalFirstName = usernameFirst + user.username.Substring(1);
            return usernameFirst;
        }
    }
}

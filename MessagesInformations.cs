using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class MessagesInformations
    {
        public static void enterToContinue()
        {
            Console.WriteLine("Press the Enter key to return to the Main menu...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine("You did not press the Enter key. Try again.");
            }
        }
        public static void WelcomeMsg()
        {
            Console.WriteLine("Welcome to the mock-bank Program!"); //Greetings
            // Prompt the user to log in
            Console.WriteLine("Please log in to continue.");
        }
        public static string PresentableName(User user)
        {
            string usernameFirst = user.username[0].ToString(); //Extracts first character of name
            usernameFirst = usernameFirst.ToUpper(); //Makes it uppcase
            string capitalFirstName = usernameFirst + user.username.Substring(1);
            return usernameFirst;
        }
    }
}

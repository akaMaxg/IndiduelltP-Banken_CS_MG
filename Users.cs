using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class User  // Define the User class with 2 properties: a username and password
    {
        public string username { get; set; }
        public int pincode { get; set; } //SET TO PRIVATE AND MAKE SET-PARAMETERS?

        public User(string username, int pincode) //Constructor that takes two parameters.
        {
            this.username = username;
            this.pincode = pincode;

        }

        public static User[] CreateUsers() //Public method that returns an array of Users
        {
            User[] users = new User[] //An array of objects, 
            {
                //Creates 5 User-objects with 2 arguments for username and password
            new User("a", 1111),
            new User("b", 2222),
            new User("c", 3333),
            new User("d", 4444),
            new User("e", 5555)
            };
            return users;
        }

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

        public static User LogIn(User user1, User user2, User user3, User user4, User user5) //Method for login sequence
        {

            Console.Write("Username: ");
            string username = Console.ReadLine().ToLower(); //Ensures name is not case-sensative
            Console.Write("Password: ");
            int pincode = int.Parse(Console.ReadLine()); //Password remains case-sensative //TRY CATCH FOR PIN
            bool ensureUser = true;
            User currentUser = null; //Declare a variable of type User to be able to set a specific user to context

            while (ensureUser)
            {

                // Check if the username and password match one of the users

                if (user1.username == username && user1.pincode == pincode) //Check to see which user logged in and sets it as the current user
                {
                    currentUser = user1;
                    ensureUser = false;
                }
                else if (user2.username == username && user2.pincode == pincode)
                {
                    currentUser = user2;
                    ensureUser = false;
                }
                else if (user3.username == username && user3.pincode == pincode)
                {
                    currentUser = user3;
                    ensureUser = false;
                }
                else if (user4.username == username && user4.pincode == pincode)
                {
                    currentUser = user4;
                    ensureUser = false;
                }
                else if (user5.username == username && user5.pincode == pincode)
                {
                    currentUser = user5;
                    ensureUser = false;
                }
                else
                {
                    Console.WriteLine("Login not successfull. Please try again."); //If no match
                }
            }
            string firstName = PresentableName(currentUser);
            Console.Clear();
            Console.WriteLine("Login successful, welcome " + firstName + "\n");
            return currentUser;
        }

        public static string PresentableName(User user)
        {
            string usernameFirst = user.username[0].ToString(); //Extracts first character of name
            usernameFirst = usernameFirst.ToUpper(); //Makes it uppcase
            string capitalFirstName = usernameFirst + user.username.Substring(1);
            return usernameFirst;
        }

        public static bool RunMenu(User currentUser, bool toRun)
        {
            //Console.WriteLine("Login succeeded. Welcome, " + usernameFirst + currentUser.username.Substring(1) + "."); //Presents the name with a capital first letter
            bool runProgram = true; //Runs program until exited by user
            while (runProgram)
            {
                // If the login is successful, present the user with a menu
                if (currentUser != null)
                {
                    Console.WriteLine("Please choose an option from the menu below: \n"); //Presents the menu
                    Console.WriteLine("     1. View Accounts and funds.");
                    Console.WriteLine("     2. Transfer funds between accounts.");
                    Console.WriteLine("     3. Withdraw funds.");
                    Console.WriteLine("     4. Log out");

                    // Read the user's menu selection
                    int menuOption = int.Parse(Console.ReadLine());

                    // Handle the user's menu selection
                    switch (menuOption)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Placeholder for viewing Accounts and Funds: Meanwhile- Password is: " + currentUser.pincode);
                            enterToContinue();
                            Console.Clear();
                            break;
                        case 2: //New password
                            Console.Clear();
                            Console.WriteLine("Placeholder for transfering funds between accounts. Meanwhile a function to change password");
                            Console.Write("Enter your new password: ");
                            int newPincode = int.Parse(Console.ReadLine()); //Accepts new password
                            currentUser.pincode = newPincode; //Sets it to the current users password
                            Console.WriteLine("Password changed.");
                            enterToContinue();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Placeholder for withdrawing funds.");
                            enterToContinue();
                            Console.Clear();
                            break;
                        case 4://Logging out
                            string firstName = PresentableName(currentUser);
                            Console.WriteLine("Logging out, goodbye " + firstName);
                            //Console.WriteLine("Logging out: " + usernameFirst + currentUser.username.Substring(1) + "."); //Farewell message
                            runProgram = false; //sets bool to false and exists while loop
                            Console.Clear();
                            Console.WriteLine("Would you like to login with a different user or exit the program?");
                            Console.WriteLine("     1. Log in with another user.");
                            Console.WriteLine("     2. Exit the bank");
                            int exitOrLogIn = int.Parse(Console.ReadLine());
                            switch (exitOrLogIn)
                            {
                                case 1:
                                    Console.WriteLine("     1. Log in with another user.");
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("     2. Exit the bank.");
                                    toRun = false;
                                    break;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid user, returning to start");
                    return toRun;
                }
            }
            return toRun;
        }
    }
}


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
        public int pincode { get; set; } 
        public double[] balances { get; set; } //Set to private and adjust SET parameters?

        public User(string username, int pincode, double[] balances)  //Constructor that takes three parameters.
        {
            this.username = username;
            this.pincode = pincode;
            this.balances = balances;
        }

        public static User[] CreateUsers() //Public method that returns an array of Users
        {
            User[] users = new User[] //An array of objects, 
            {
                //Creates 5 User-objects with 3 arguments for username and password, balances
            new User("a", 1111, new double[] { 101.0, 102.0, 103.0 }),
            new User("b", 2222, new double[] { 201.0, 202.0, 203.0 }),
            new User("c", 3333, new double[] { 301.0, 302.0, 303.0 }),
            new User("d", 4444, new double[] { 401.0, 402.0, 403.0 }),
            new User("e", 5555, new double[] { 501.0, 502.0, 503.0 })
            };
            return users;
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
            string firstName = MessagesInformations.PresentableName(currentUser);
            Console.Clear();
            Console.WriteLine("Login successful, welcome " + firstName + "\n");
            return currentUser;
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
                            MessagesInformations.enterToContinue();
                            Console.Clear();
                            break;
                        case 2: //New password
                            Console.Clear();
                            Console.WriteLine("Placeholder for transfering funds between accounts. Meanwhile a function to change password");
                            Console.Write("Enter your new password: ");
                            int newPincode = int.Parse(Console.ReadLine()); //Accepts new password
                            currentUser.pincode = newPincode; //Sets it to the current users password
                            Console.WriteLine("Password changed.");
                            MessagesInformations.enterToContinue();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Placeholder for withdrawing funds.");
                            MessagesInformations.enterToContinue();
                            Console.Clear();
                            break;
                        case 4://Logging out
                            string firstName = MessagesInformations.PresentableName(currentUser);
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


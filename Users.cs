using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class User  // Define the User class with 2 properties: a username and password
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string username, string password) //Constructor that takes two parameters.
        {
            this.username = username;
            this.password = password;

        }

        public static User[] CreateUsers() //Public method that returns an array of Users
        {
            User[] users = new User[] //An array of objects, 
            {
                //Creates 5 User-objects with 2 arguments for username and password
            new User("a", "one"),
            new User("b", "two"),
            new User("c", "three"),
            new User("d", "four"),
            new User("e", "five")
            };
            return users;
        }

        public static User LogIn(User user1, User user2, User user3, User user4, User user5) //Method for login sequence
        {
            CreateUsers();
            Console.WriteLine("Welcome to the mock-bank Program!"); //Greetings

            // Prompt the user to log in
            Console.WriteLine("Please log in to continue.");
            Console.Write("Username: ");
            string username = Console.ReadLine().ToLower(); //Ensures name is not case-sensative
            Console.Write("Password: ");
            string password = Console.ReadLine(); //Password remains case-sensative
            bool ensureUser = true;
            User currentUser = null; //Declare a variable of type User to be able to set a specific user to context

            while (ensureUser)
            {

                // Check if the username and password match one of the users

                if (user1.username == username && user1.password == password) //Check to see which user logged in and sets it as the current user
                {
                    currentUser = user1;
                    ensureUser = false;
                }
                else if (user2.username == username && user2.password == password)
                {
                    currentUser = user2;
                    ensureUser = false;
                }
                else if (user3.username == username && user3.password == password)
                {
                    currentUser = user3;
                    ensureUser = false;
                }
                else if (user4.username == username && user4.password == password)
                {
                    currentUser = user4;
                    ensureUser = false;
                }
                else if (user5.username == username && user5.password == password)
                {
                    currentUser = user5;
                    ensureUser = false;
                }
                else
                {
                    Console.WriteLine("Login not successfull. Please try again."); //If no match
                }
            }
            return currentUser;

        }

        public static void RunMenu(User currentUser)
        {
            string usernameFirst = currentUser.username[0].ToString(); //Extracts first character of name
            usernameFirst = usernameFirst.ToUpper(); //Makes it uppcase
            Console.WriteLine("Login succeeded. Welcome, " + usernameFirst + currentUser.username.Substring(1) + "."); //Presents the name with a capital first letter
            bool runProgram = true; //Runs program until exited by user
            while (runProgram)
            {
                // If the login is successful, present the user with a menu
                if (currentUser != null)
                {
                    Console.WriteLine("Please choose an option from the menu below:"); //Presents the menu
                    Console.WriteLine("1. Change password");
                    Console.WriteLine("2. Log out");

                    // Read the user's menu selection
                    int menuOption = int.Parse(Console.ReadLine());

                    // Handle the user's menu selection
                    switch (menuOption)
                    {
                        case 1: //New password
                            Console.Write("Enter your new password: ");
                            string newPassword = Console.ReadLine(); //Accepts new password
                            currentUser.password = newPassword; //Sets it to the current users password
                            Console.WriteLine("Password changed.");
                            break;
                        case 2: //Logging out
                            Console.WriteLine("Logging out: " + usernameFirst + currentUser.username.Substring(1) + "."); //Farewell message
                            runProgram = false; //sets bool to false and exists while loop
                            break;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class User  // Define the User class with 4 properties: a username and password, accountnames and balance
    {
        public string username { get; set; }
        public int pincode { get; set; }
        public string[] accountNames { get; set; }

        public double[] balances { get; set; } //Set to private and adjust SET parameters?

        public User(string username, int pincode, string[] accountNames, double[] balances)  //Constructor that takes five parameters.
        {
            this.username = username;
            this.pincode = pincode;
            this.balances = balances;
            this.accountNames = accountNames;
        }

        public static User[] CreateUsers() //Method that returns an array of Users with pre-set information.
        {
            User[] users = new User[] //An array of objects, 
            {
                //Creates 5 User-objects with 3 arguments for username and password, balances
            new User("a", 1111, new string[] {"Primary", "Secondary", "Savings", "Nominal" }, new double[] { 0, 0, 0, 0 }),
            new User("b", 2222, new string[] {"Primary", "Secondary" }, new double[] { 0, 0 }),
            new User("c", 3333, new string[] {"Primary", "Secondary", "Savings" }, new double[] { 0, 0, 0 }),
            new User("d", 4444, new string[] {"Primary", "Savings"}, new double[] { 0, 0 }),
            new User("e", 5555, new string[] {"Primary", "Secondary", "Savings" }, new double[] { 0, 0, 0 })
            };
            return users;
        }
        public static User LogIn(User user1, User user2, User user3, User user4, User user5) //Method for login sequence
        {
            bool ensureUser = true; //Loops until user manages to log in
            User currentUser = null; //Declare a variable of type User to be able to set a specific user to context

            while (ensureUser)
            {
                Console.Write("Username: ");
                string username = Console.ReadLine().ToLower(); //Ensures name is not case-sensative and takes username input
                Console.Write("Pincode: ");

                bool correctInput = true;
                int pincode = 0;

                while (correctInput)
                {
                    try
                    {
                        pincode = int.Parse(Console.ReadLine()); //Password remains case-sensative, password input
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Pincode must be a 4-digit code");
                    }
                }
                // Check if the username and password match one of the users and sets/returns it as the current user

                if (user1.username == username && user1.pincode == pincode)
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
            string firstName = MessagesInformations.PresentableName(currentUser); //Makes sure the user is greeted properly
            Console.Clear();
            Console.WriteLine("Login successful, welcome " + firstName + "\n");
            return currentUser;
        }
    }
}


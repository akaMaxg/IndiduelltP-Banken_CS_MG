namespace IndiduelltP_Banken_CS_MG
{
    internal class Program
    {



    static void Main(string[] args)
        {

            User[] users = User.CreateUsers(); //Create user returns an array of 5 users,
            bool runBank = true; // 2 variables to see if the program should keep running
            MessagesInformations.WelcomeMsg(); //function that posts a welcome message
            BankFunctions.PopulateAccounts(users); //Method to populate all users bank accounts with funds

            while (runBank) //Loop Mainprogram
            {
                //LogIn function based off users initiated above. 
                User currentUser = User.LogIn(users[0], users[1], users[2], users[3], users[4]); //Login function sets currentUser.
                //Function RunMenu returns a true or false. 
                //If user selected newUser, the function will return true and this while loop exists
                //if user selected exit bank, this function will return false and exits the while loop
                //The function allows for internal iterations.
                runBank = BankFunctions.RunMenu(currentUser, runBank);
            }
            Console.Clear();
            Console.WriteLine("Thank you for using the bank.");
        }
    }
}


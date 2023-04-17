namespace IndiduelltP_Banken_CS_MG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = User.CreateUsers(); //Create user returns an array of 5 users
            BankFunctions.PopulateAccounts(users); //Method to populate all users bank accounts with funds
            bool runBank = true; // variables to see if the program should keep running

            MessagesInformations.WelcomeMsg(); //function that posts a welcome message
            while (runBank) //Loop Mainprogram
            {
                User currentUser = User.LogIn(users[0], users[1], users[2], users[3], users[4]); //Login function that sets currentUser.
                runBank = BankFunctions.RunMenu(currentUser, runBank); //Function RunMenu returns a true or false. 
                                                                       //If user selected newUser, the function will return true and this while loop exists
                                                                       //if user selected exit bank, this function will return false and exits the while loop
            }
            Console.Clear();
            Console.WriteLine("!!!"); //After exiting the runBank loop
        }
    }
}
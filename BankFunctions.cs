using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace IndiduelltP_Banken_CS_MG
{
    public class BankFunctions
    {
        public static bool RunMenu(User currentUser, bool toRun) //Main program
        {
            bool runProgram = true; //Runs program until exited by user
            while (runProgram)
            {
                if (currentUser != null)
                {
                    Console.WriteLine("Please choose an option from the menu below: \n"); //Presents the menu
                    Console.WriteLine("     1. View Accounts and funds.");
                    Console.WriteLine("     2. Transfer funds between accounts.");
                    Console.WriteLine("     3. Withdraw funds.");
                    Console.WriteLine("     4. Log out");

                    bool correctInput = true;
                    int menuOption = 0;

                    while (correctInput)
                    {
                        try
                        {
                            menuOption = int.Parse(Console.ReadLine()); //Menu choice
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Input must be a number");
                        }
                    }


                    switch (menuOption)// Handle the user's menu selection
                    {
                        case 1: //View accounts
                            Console.Clear();
                            Console.WriteLine("List of accounts... ");
                            ViewAccounts(currentUser);
                            MessagesInformations.enterToContinue();
                            Console.Clear();
                            break;
                        case 2: //Transfer funds
                            Console.Clear();
                            TransferFunds(currentUser);
                            MessagesInformations.enterToContinue();
                            Console.Clear();
                            break;
                        case 3: //Withdraw Funds
                            Console.Clear();
                            WithdrawFunds(currentUser);
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
                            int exitOrLogin = 0;
                            try
                            {
                                exitOrLogin = int.Parse(Console.ReadLine());
                                switch (exitOrLogin)
                                {
                                    case 1:
                                        Console.WriteLine("     1. Log in with another user.");
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine("     2. Exit the bank.");
                                        toRun = false;
                                        break;
                                    default:
                                        Console.WriteLine("Improper input, returning to login...");
                                        break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Improper input, returning to login...");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid user, returning to start");
                    return toRun; //Exits loop and re-prompts login
                }
            }
            return toRun; //Exits loop and re-prompts login
        }
        static public void PopulateAccounts(User[] user) //Function that generates balances and adds it to an array
        {
            Random rnd = new Random();
            for (int i = 0; i < user.Length; i++)
            {
                //Console.WriteLine(user[i].username);
                for (int j = 0; j < user[i].balances.Length; j++)
                {
                    double randomBalance = rnd.NextDouble() * 100000;
                    user[i].balances[j] = Math.Round(randomBalance, 3);
                    //Console.Write(user[i].accountNames[j] + ": ");
                    //Console.WriteLine(user[i].balances[j]);
                }
            }
        }
        public static void ViewAccounts(User currentUser) //Function that presents accountnames
        {
            for (int j = 1; j <= currentUser.accountNames.Length; j++)
            {
                Console.WriteLine(j + ". " + currentUser.accountNames[j - 1] + ": " + currentUser.balances[j - 1]);
            }
        }
        public static int ChooseAccount(User currentUser) //Funtion that returns which account is being selected
        {
            int i = 0;
            bool correctInput = true;
            while (i != 1 && i != 2 && i != 3 && i != 4)
            {
                ViewAccounts(currentUser);
                while (correctInput)
                {
                    try
                    {
                        i = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input must be a number");
                    }
                }
            }
            return i;
        }
        public static void ViewBalance(User currentUser) //Function that returns the balances for the users accounts
        {
            double y = 0;
            for (int k = 0; k < currentUser.balances.Length; k++)
            {
                Console.WriteLine(currentUser.balances[k]);
            }
        }
        public static void TransferFunds(User currentUser) //function that allows transfers between account
        {
            Console.WriteLine("Which account would you like to transfer from?");
            int fromAccount = BankFunctions.ChooseAccount(currentUser);
            Console.WriteLine("Which account would you like to transfer to? ");
            int toAccount = BankFunctions.ChooseAccount(currentUser);
            Console.Write("Enter amount: ");
            bool correctInput = true;
            double amountTransfer = 0;
            while (correctInput)
            {
                try
                {
                    amountTransfer = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a number");
                }
            }

            if (amountTransfer > currentUser.balances[fromAccount - 1])
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                currentUser.balances[fromAccount - 1] = currentUser.balances[fromAccount - 1] - amountTransfer; //Since array starts at [0] and user input is from 1-3
                currentUser.balances[toAccount - 1] = currentUser.balances[toAccount - 1] + amountTransfer;
                Console.WriteLine("Transfered " + amountTransfer + " from " + currentUser.accountNames[fromAccount - 1] + " account to " + currentUser.accountNames[toAccount - 1] + " account.\nRemaining balance:...\n");
                BankFunctions.ViewAccounts(currentUser);
            }
        }
        public static void WithdrawFunds(User currentUser) //Function that allows withdrawals from account
        {
            Console.WriteLine("From which Account?");
            int fromAccount = BankFunctions.ChooseAccount(currentUser);
            Console.WriteLine("How much funds would you like to withdraw?");
            Console.Write("Enter amount: ");
            bool correctInput = true;
            double amountWithdraw = 0;
            while (correctInput)
            {
                try
                {
                    amountWithdraw = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be a number");
                }
            }
            if (amountWithdraw > currentUser.balances[fromAccount - 1])
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {

                Console.Write("Enter your pin again to confirm that you want to withdraw funds: ");
                int tempPin = int.Parse(Console.ReadLine());
                if (currentUser.pincode == tempPin) //Check to confirm that the correct users is attempting withdrawal
                {

                    Console.WriteLine("Withdrawing " + amountWithdraw + " SEK " + "from account: " + currentUser.accountNames[fromAccount - 1]);
                    currentUser.balances[fromAccount - 1] = currentUser.balances[fromAccount - 1] - amountWithdraw;
                    Console.WriteLine("Balance remaining: " + currentUser.balances[fromAccount - 1] + " SEK");
                }
                else
                {
                    Console.WriteLine("Incorrect pincode");
                    Console.ReadLine();
                }
            }
        }
    }
}



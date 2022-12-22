
# Individuellt Projekt Banken C#, Max Guclu, Chas Academy Fullstack .NET

## Fullstack-NET_MaxG_ChasAcademy22 Banken
Welcome to the individual assignment The Bank, in C#
This project is a simple bank that allows for some basic login and transaction function in a console program.

## Prerequisites
To the project, you will need the following software installed on your machine:
* .NET Core

## Running the program
To run the project, follow these steps:
 - Open a terminal window and navigate to the root directory of the project.
 - Run the following command to start the application: dotnet run
 - Alternatively use an IDE to run it

## Usage
Once the application is running, you can use it by following the on-screen prompts.
The predetermined username and pincodes are 
- "a", "1111"
- "b", "2222"
- "c", "3333"
- "d", "4444"
- "e", "5555"

## Contributions & Feedback
If you would like to contribute to this project, please fork the repository and submit a pull request. All contributions, and feedbacks are welcome and appreciated!

### The program
- The program runs on three main concepts
- 1. A class User. This class allows for the creation of users with 5 parameters: Usernames, pincodes, an array[3] with bank accounts and an array[3] of balance
  This class also contains a method that instansiates 5 users with hard-coded parameters
- 2. A Run Menu method in the Bank Function's class. This menu is contained in a while loop which allows the users to perform multiple functions indefinetaly or until funds are 0 
   It is primarily based on a switch case where the various options call methods in the program. 
   It also allows for a logout which does not exit the entire bank-program, but the specific menu process
- 3. The Main process. The important part here is that the Run menu program resides in a while loop. The while loop allows for the bank to be rerun with other users.
	 The entire program does not exit until a user has specifically selected exit in the run menu function which sets "run bank" to false and exits the loop
	 In addition the main function populates the balances and greets users.

#### Overall
In general, the entire program is divided into Messages and Informations, Bank Functions, Users and Program. This is to make the code accessible and easy to maintain. 
The code accomodates typos, wrong types of input and runtime exceptions

## The requirements listed for the assignment below with motivation to how I've solved them:

##### [X] Användare skall välkomnas till banken
- Användaren välkomnas med funktion WelcomeMsg under klass MessagesInformations.

##### [X] Användaren ska mata in sitt användarnummer/Namn och en pinkod som avgör vilken användare det är
- Användaren ombes att logga in med LogIn funktion som jämförs mot aktiva 'User' instanser. Denna sätter också aktiv användare

##### [X] Bankomaten skall ha 5 olika använare som ska kunna använda den, behöver EJ kunna läggas till fler
- Fem instanser av User har skapats med färdiga parametrar

##### [X] Meny med 4 val:
- Se Konto och saldo
- Överföring mellan konton
- Ta ut pengar
- Logga ut

##### [X] Användaren väljer funktion genom en siffra.

##### [X] När en funktion kör klart skall användaren få upp text "Tryck enter för att komma till huvudmenyn, när denna gjort det kommer menyn upp igen
- Detta görs av funktion enterToContinue i klass MessagesInformations. 

##### [X] Om användaren väljer logga ut ska programmet ta användaren till inloggning igen
- Huvudprogrammet körs i en while-loop. Om användaren väljer logga in med ny användare körs while loopen och "runMenu" vidare, annars sätts while-loopen till false och huvudprogrammet bryts.

##### [X] Om användaren skriver ett nummer som inte finns i menyn eller något annat ska systemet meddela ogiltigt val
- Default till switch funktionen som styr menyn uppmanar ett alternativ i menyn.

##### [X] 1. Se konton och saldo
##### [X] Funktionen körs när alternativet är valt
##### [X] Utskrift av olika konton som användaren har och hur mycket pengar finns på dessa
- Görs av en funktion ViewAccounts under BankFunctions som itererar igenom kontona för aktiva användaren och presenterar dem
##### [X] Ska se både kronor och ören
[X] Kontonen ska ha olika namn, t.ex. lönekonto
- De är döpta till Primary, Secondary och Savings. Dessa nämns vid instansering av User
##### [X] Saldon för alla konton sätts vid starten av programmet vid start av programmet, om programmet startar om återställs dessa
- Körs ett PopulateAccounts metod i början som randomar ett tal mellan 0 - 100.000 vid varje körning och fyller alla tre konton för samtliga användare.

##### [X] 2. Överföring mellan konton
##### [X] Funktionen körs när alternativet är valt
##### [X] Användaren ska kunna välja konto att ta ut pengar ifrån, ett konto att flytta pengarna till och sen summa som ska flyttas mellan
- Detta görs med en TransferFunds metod under BankFunctions som hämtar och sätter värdena på konto-arrayen för den aktiva användaren
##### [X] Summan ska sedan flyttas mellan kontonen och efteråt ska användaren få se vilken summa som finns på dessa två konton
- Samma metod adderar angivna värdet till till-kontot, och subtraherar från från-kontot
##### [X] Det måste finnas täckning från kontot man vill flytta
- En if-sats säkerställer att det finns saldo.
##### [X] 3. Ta ut pengar
##### [X] Funktionen körs när användaren navigerat till ta ut pengar
##### [X] Användaren ska kunna välja ett av sina konton och en summa
- Användaren får prompt vilket konto som pengarna ska tas ut ifrån och hur mycket
##### [X] Efter detta måste användaren skriva in sin pinkod för att verifiera att de vill ta ut pengar
- En prompt där användaren får sätta i sitt lösenord kollar mot aktiva användarens lösenord och en if sats styr om uttaget görs eller inte.
##### [X] Pengarna tas sedan bort från det kontot som valdes. 
- Samma metod subtraherar sedan det angivna värdet från det valda kontot för den aktiva användaren

##### [X] Projektet ska byggas i Visual Studio med C# och .NET Core 6 som en Console Application

##### [X] Alla namn på filer, variabler, metoder etc SKA vara på engelska
##### [X] Projektet MÅSTE innehålla flera olika typer av datatyper varav array måste vara en av dessa
- Array
- Bool
- Double
- Int
- String

##### [X] Projektet MÅSTE använda flera typer av programstrukturer/programflöden; villkor och loopar
- Genomgående i projektet finns switch-funktioner, if-satser, for- och whileloopar samt jämförparametrar.
##### [X] Projektet MÅSTE innehålla minst tre olika metoder/funktioner som du skapat själv
- Projektet innehåller 3 egenskapade klasser
- med Ca 12 egenskapade metoder
##### [X] Projektet MÅSTE versionshanteras med Git. Du ska ha sparat löpande till Github under arbetet
##### [X] Det SKA finnas en del kommentarer i koden. Dels som förklarar vad varje metod eller del av koden gör (ex. de olika funktionerna i programmet)
##### [X] samt kommentarer för kodrader som inte är helt uppenbara vad de gör eller hur de fungerar.
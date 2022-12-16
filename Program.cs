namespace IndiduelltP_Banken_CS_MG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = User.CreateUsers(); //Create user returns an array of 5 users, 
            //Users are placed into User-type variables
            User user1 = users[0];
            User user2 = users[1];
            User user3 = users[2];
            User user4 = users[3];
            User user5 = users[4];


            User currentUser = User.LogIn(user1, user2, user3, user4, user5);

            User.RunMenu(currentUser);
        }
    }
}

//Användare skall välkomnas till banken
//Användaren ska mata in sitt användarnummer/Namn och en pinkod som avgör vilken användare det är
//Bankomaten skall ha 5 olika använare som ska kunna använda den, behöver EJ kunna läggas till fler

//Väl inloggad_
//Meny med 4 val:
//Se Konto och saldo
//Överföring mellan konton
//Ta ut pengar
//Logga ut

//Användaren väljer funktion genom en siffra.
//När en funktion kör klart skall användaren få upp text "Tryck enter för att komma till huvudmenyn, när denna gjort det kommer menyn upp igen
//Om användaren väljer logga ut ska programmet ta användaren till inloggning igen
//Om användaren skriver ett nummer som inte finns i menyn eller något annat ska systemet meddela ogiltigt val
// 1. Se konton och saldo
// Funktionen körs när alternativet är vlat
// Utskrift av olika konton som användaren har och hur mycket pengar finns på dessa
// Ska se både kronor och ören
//Kontonen ska ha olika namn, t.ex. lönekonto
//Saldon för alla konton sätts vid starten av programmet vid start av programmet, om programmet startar om återställs dessa
// 2. Överföring mellan konton
// Funktionen körs när alternativet är valt
// Användaren ska kunna välja konto att ta ut pengar ifrån, ett konto att flytta pengarna till och sen summa som ska flyttas mellan
// Summan ska sedan flyttas mellan kontonen och efteråt ska användaren få se vilken summa som finns på dessa två konton
// Det måste finnas täckning från kontot man vill flytta
// 3. Ta ut pengar
// Funktionen körs när användaren navigerat till ta ut pengar
// Användaren ska kunna välja ett av sina konton och en summa
// Efter detta måste användaren skriva in sin pinkod för att verifiera att de vill ta ut pengar
// Pengarna tas sedan bort från det kontot som valdes. 

//Projektet ska byggas i Visual Studio med C# och .NET Core 6 som en Console Application

//Alla namn på filer, variabler, metoder etc SKA vara på engelska
//Projektet MÅSTE innehålla flera olika typer av datatyper varav array måste vara en av dessa
//Projektet MÅSTE använda flera typer av programstrukturer/programflöden; villkor och loopar
//Projektet MÅSTE innehålla minst tre olika metoder/funktioner som du skapat själv
//Projektet MÅSTE versionshanteras med Git. Du ska ha sparat löpande till Github under arbetet
//Det SKA finnas en del kommentarer i koden. Dels som förklarar vad varje metod eller del av koden gör (ex. de olika funktionerna i programmet)
//samt kommentarer för kodrader som inte är helt uppenbara vad de gör eller hur de fungerar.
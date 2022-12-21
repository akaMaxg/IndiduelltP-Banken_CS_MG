# IndividuellP-Banken_CS_MG
##Projekt banken, C#, Max Guclu, FS.NET

#How the program works
The program runs on two primary logical processer.
One which runs in Main
Second which runs in BankFunctions.



[X] Användare skall välkomnas till banken
- Användaren välkomnas med funktion WelcomeMsg under klass MessagesInformations.

[X] Användaren ska mata in sitt användarnummer/Namn och en pinkod som avgör vilken användare det är
- Användaren ombes att logga in med LogIn funktion som jämförs mot aktiva 'User' instanser. Denna sätter också aktiv användare

[X] Bankomaten skall ha 5 olika använare som ska kunna använda den, behöver EJ kunna läggas till fler
- Fem instanser av User har skapats med färdiga parametrar

[X]Meny med 4 val:
- Se Konto och saldo
- Överföring mellan konton
- Ta ut pengar
- Logga ut

[X] Användaren väljer funktion genom en siffra.


[X] När en funktion kör klart skall användaren få upp text "Tryck enter för att komma till huvudmenyn, när denna gjort det kommer menyn upp igen
- Detta görs av funktion enterToContinue i klass MessagesInformations. 

[X] Om användaren väljer logga ut ska programmet ta användaren till inloggning igen
- Huvudprogrammet körs i en while-loop. Om användaren väljer logga in med ny användare körs while loopen och "runMenu" vidare, annars sätts while-loopen till false och huvudprogrammet bryts.

[X] Om användaren skriver ett nummer som inte finns i menyn eller något annat ska systemet meddela ogiltigt val
- Default till switch funktionen som styr menyn uppmanar ett alternativ i menyn.

[X] 1. Se konton och saldo
[X] Funktionen körs när alternativet är valt
[X]-Utskrift av olika konton som användaren har och hur mycket pengar finns på dessa
- Görs av en funktion ViewAccounts under BankFunctions som itererar igenom kontona för aktiva användaren och presenterar dem
[X]-Ska se både kronor och ören
[X]-Kontonen ska ha olika namn, t.ex. lönekonto
- De är döpta till Primary, Secondary och Savings. Dessa nämns vid instansering av User
[X]-Saldon för alla konton sätts vid starten av programmet vid start av programmet, om programmet startar om återställs dessa
- Körs ett PopulateAccounts metod i början som randomar ett tal mellan 0 - 100.000 vid varje körning och fyller alla tre konton för samtliga användare.

[X] 2. Överföring mellan konton
[X]Funktionen körs när alternativet är valt
[X]Användaren ska kunna välja konto att ta ut pengar ifrån, ett konto att flytta pengarna till och sen summa som ska flyttas mellan
- Detta görs med en TransferFunds metod under BankFunctions som hämtar och sätter värdena på konto-arrayen för den aktiva användaren
[X] Summan ska sedan flyttas mellan kontonen och efteråt ska användaren få se vilken summa som finns på dessa två konton
- Samma metod adderar angivna värdet till till-kontot, och subtraherar från från-kontot
[X] Det måste finnas täckning från kontot man vill flytta
- En if-sats säkerställer att det finns saldo.
[X] 3. Ta ut pengar
[X] Funktionen körs när användaren navigerat till ta ut pengar
[X] Användaren ska kunna välja ett av sina konton och en summa
- Användaren får prompt vilket konto som pengarna ska tas ut ifrån och hur mycket
[X] Efter detta måste användaren skriva in sin pinkod för att verifiera att de vill ta ut pengar
- En prompt där användaren får sätta i sitt lösenord kollar mot aktiva användarens lösenord och en if sats styr om uttaget görs eller inte.
[X] Pengarna tas sedan bort från det kontot som valdes. 
- Samma metod subtraherar sedan det angivna värdet från det valda kontot för den aktiva användaren

[X] Projektet ska byggas i Visual Studio med C# och .NET Core 6 som en Console Application

[X]Alla namn på filer, variabler, metoder etc SKA vara på engelska
[X] Projektet MÅSTE innehålla flera olika typer av datatyper varav array måste vara en av dessa
-Array
-Bool
-Double
-Int
-String

[X] Projektet MÅSTE använda flera typer av programstrukturer/programflöden; villkor och loopar
- Genomgående i projektet finns switch-funktioner, if-satser, for- och whileloopar samt jämförparametrar.
[X] Projektet MÅSTE innehålla minst tre olika metoder/funktioner som du skapat själv
- Projektet innehåller 3 egenskapade klasser
- med Ca 12 egenskapade metoder
[X] Projektet MÅSTE versionshanteras med Git. Du ska ha sparat löpande till Github under arbetet
[X] Det SKA finnas en del kommentarer i koden. Dels som förklarar vad varje metod eller del av koden gör (ex. de olika funktionerna i programmet)
[X] samt kommentarer för kodrader som inte är helt uppenbara vad de gör eller hur de fungerar.
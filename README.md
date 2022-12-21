# IndividuellP-Banken_CS_MG
##Projekt banken, C#, Max Guclu, FS.NET

#How the program works
The program runs on two primary logical processer.
One which runs in Main
Second which runs in BankFunctions.



[X] Anv�ndare skall v�lkomnas till banken
- Anv�ndaren v�lkomnas med funktion WelcomeMsg under klass MessagesInformations.

[X] Anv�ndaren ska mata in sitt anv�ndarnummer/Namn och en pinkod som avg�r vilken anv�ndare det �r
- Anv�ndaren ombes att logga in med LogIn funktion som j�mf�rs mot aktiva 'User' instanser. Denna s�tter ocks� aktiv anv�ndare

[X] Bankomaten skall ha 5 olika anv�nare som ska kunna anv�nda den, beh�ver EJ kunna l�ggas till fler
- Fem instanser av User har skapats med f�rdiga parametrar

[X]Meny med 4 val:
- Se Konto och saldo
- �verf�ring mellan konton
- Ta ut pengar
- Logga ut

[X] Anv�ndaren v�ljer funktion genom en siffra.


[X] N�r en funktion k�r klart skall anv�ndaren f� upp text "Tryck enter f�r att komma till huvudmenyn, n�r denna gjort det kommer menyn upp igen
- Detta g�rs av funktion enterToContinue i klass MessagesInformations. 

[X] Om anv�ndaren v�ljer logga ut ska programmet ta anv�ndaren till inloggning igen
- Huvudprogrammet k�rs i en while-loop. Om anv�ndaren v�ljer logga in med ny anv�ndare k�rs while loopen och "runMenu" vidare, annars s�tts while-loopen till false och huvudprogrammet bryts.

[X] Om anv�ndaren skriver ett nummer som inte finns i menyn eller n�got annat ska systemet meddela ogiltigt val
- Default till switch funktionen som styr menyn uppmanar ett alternativ i menyn.

[X] 1. Se konton och saldo
[X] Funktionen k�rs n�r alternativet �r valt
[X]-Utskrift av olika konton som anv�ndaren har och hur mycket pengar finns p� dessa
- G�rs av en funktion ViewAccounts under BankFunctions som itererar igenom kontona f�r aktiva anv�ndaren och presenterar dem
[X]-Ska se b�de kronor och �ren
[X]-Kontonen ska ha olika namn, t.ex. l�nekonto
- De �r d�pta till Primary, Secondary och Savings. Dessa n�mns vid instansering av User
[X]-Saldon f�r alla konton s�tts vid starten av programmet vid start av programmet, om programmet startar om �terst�lls dessa
- K�rs ett PopulateAccounts metod i b�rjan som randomar ett tal mellan 0 - 100.000 vid varje k�rning och fyller alla tre konton f�r samtliga anv�ndare.

[X] 2. �verf�ring mellan konton
[X]Funktionen k�rs n�r alternativet �r valt
[X]Anv�ndaren ska kunna v�lja konto att ta ut pengar ifr�n, ett konto att flytta pengarna till och sen summa som ska flyttas mellan
- Detta g�rs med en TransferFunds metod under BankFunctions som h�mtar och s�tter v�rdena p� konto-arrayen f�r den aktiva anv�ndaren
[X] Summan ska sedan flyttas mellan kontonen och efter�t ska anv�ndaren f� se vilken summa som finns p� dessa tv� konton
- Samma metod adderar angivna v�rdet till till-kontot, och subtraherar fr�n fr�n-kontot
[X] Det m�ste finnas t�ckning fr�n kontot man vill flytta
- En if-sats s�kerst�ller att det finns saldo.
[X] 3. Ta ut pengar
[X] Funktionen k�rs n�r anv�ndaren navigerat till ta ut pengar
[X] Anv�ndaren ska kunna v�lja ett av sina konton och en summa
- Anv�ndaren f�r prompt vilket konto som pengarna ska tas ut ifr�n och hur mycket
[X] Efter detta m�ste anv�ndaren skriva in sin pinkod f�r att verifiera att de vill ta ut pengar
- En prompt d�r anv�ndaren f�r s�tta i sitt l�senord kollar mot aktiva anv�ndarens l�senord och en if sats styr om uttaget g�rs eller inte.
[X] Pengarna tas sedan bort fr�n det kontot som valdes. 
- Samma metod subtraherar sedan det angivna v�rdet fr�n det valda kontot f�r den aktiva anv�ndaren

[X] Projektet ska byggas i Visual Studio med C# och .NET Core 6 som en Console Application

[X]Alla namn p� filer, variabler, metoder etc SKA vara p� engelska
[X] Projektet M�STE inneh�lla flera olika typer av datatyper varav array m�ste vara en av dessa
-Array
-Bool
-Double
-Int
-String

[X] Projektet M�STE anv�nda flera typer av programstrukturer/programfl�den; villkor och loopar
- Genomg�ende i projektet finns switch-funktioner, if-satser, for- och whileloopar samt j�mf�rparametrar.
[X] Projektet M�STE inneh�lla minst tre olika metoder/funktioner som du skapat sj�lv
- Projektet inneh�ller 3 egenskapade klasser
- med Ca 12 egenskapade metoder
[X] Projektet M�STE versionshanteras med Git. Du ska ha sparat l�pande till Github under arbetet
[X] Det SKA finnas en del kommentarer i koden. Dels som f�rklarar vad varje metod eller del av koden g�r (ex. de olika funktionerna i programmet)
[X] samt kommentarer f�r kodrader som inte �r helt uppenbara vad de g�r eller hur de fungerar.
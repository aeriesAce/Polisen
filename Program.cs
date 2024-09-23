/*1. Registrering av utryckningar.
     Möjlighet att detaljerat registrera varje enskild utryckning med parametrar
     - Stöld, bråk, trafikbrott mm
     - PLATS, TIDPUNKT, vilka POLISER som deltog
  2. Rapporter
     När en utryckning är över måste en rapport skrivas
     Rapporten ska innehålla
     - RAPPORTNUMMER, DATUM, POLISSTATION som hanterar ärendet, BESKRIVNING
  3. Personal
     Registrera personal med NAMN och TJÄNSTENUMMER
  4. Informationsammanställning 
     Klara och koncisa kommandon
     Snabb och enkel åtkomst till listor och detaljerad information om
     - UTRYCKNINGAR, RAPPORTER, PERSONAL */

      internal class Program
 {
     static void Main(string[] args)
     {
         int logInNumber = 0;
         int logInPassword = 0;
         //Skapa en meny, skapa sedan olika menyer för varje bransch, börjar med en och sen utökar
         //skapa inlogg för olika brancsher, börjar med en och sen utökar
         //spara inloggen i en klass??? och sen checka av till vilken brancsh personen tillhör.
         //Dem 4 första siffrorna är kopplat till en specifik brancsh.
         while (true)
         {
             //försöka implementera en try parse här istället??
             try
             {
                 //huvudmenyn där polisen loggar in
                 Console.ForegroundColor = ConsoleColor.Blue;
                 Console.WriteLine("------Huvudmenyn------");
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("Ange ditt Tjänstenummer: ");
                 logInNumber = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ange ditt lösenord: ");
                 logInPassword = int.Parse(Console.ReadLine());
                 Console.Clear();
             }
             catch
             {
                 Console.ForegroundColor= ConsoleColor.Red;
                 Console.WriteLine("Du kan endast mata in siffor. \nVänligen försök igen");
             }
             //tillfälliga villkor, ska jämföra om tjänstenumret och lösenordet är korrekt
             if(logInNumber == 4)
             {
                 AdminMenu();
             }
         }
     }
     static void AdminMenu()
     {
         try
         {
             while (true)
             {
                 //"undermenyn" där polisen får skriva rapporter mm
                 //här ska namnet på personen som loggade in stå.
                 Console.ForegroundColor = ConsoleColor.Blue;
                 Console.WriteLine("------Välkommen admin------");
                 Console.ForegroundColor = ConsoleColor.White;
                 Console.WriteLine("1. Registrera en utryckning");
                 Console.WriteLine("2. Skriv en rapport");
                 Console.WriteLine("3. Lägg till ny personal");
                 Console.WriteLine("4. Informationssammanställning");
                 Console.WriteLine("5. Logga ut");
                 int userChoice = int.Parse(Console.ReadLine());

                 //switch istället för en massa ifs, allt ska skötas i metoderna
                 switch (userChoice)
                 {
                     case 1:
                         RegisterUtryckning();
                         break;
                     case 2:
                         RegisterReports();
                         break;
                     case 3:
                         AddPersonel();
                         break;
                         case 4:
                             PrintInformation();
                         break;
                     case 5:
                         Console.WriteLine("Du loggas nu ut..");
                         Thread.Sleep(1500);
                         //vi vill gå tillbaka till huvudmenyn.
                         Environment.Exit(0);
                         break;
                 }
             }
         }
         catch
         {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Du kan endast mata in siffor. \nVänligen försök igen");
         }
     }
     static void RegisterUtryckning()
     {
         //metod för att registrera utryckningarna
         //detta ska upptaderas så vi kan använda denna till olika branscher
         Console.WriteLine("Kamehameha");
     }
     static void RegisterReports()
     {
         //metod för att fylla i rapporter
         //detta ska upptaderas så vi kan använda denna till olika branscher
         Console.WriteLine("Rasengan");
     }
     static void AddPersonel()
     {
         //lägg till personal
         //detta ska upptaderas så vi kan använda denna till olika branscher
         Console.WriteLine("Gomu Gomu no");
     }
     static void PrintInformation()
     {
         //skriva ut information om utryckningar, rapporter och personal
         //i informationen ska allt tillsammans skriva ut.
         //detta ska upptaderas så vi kan använda denna till olika branscher
         Console.WriteLine("Omnislash");
     }
 }
 class Utryckning
 {
     //skapar en lista så vi kan spara värdena
     List<Utryckning> depart = new List<Utryckning>();
     //sätter egenskaper för brott, stöld, bråk, trafikbrott
     //sätter egenskaper för plats, tidpunkt, poliser
     public string theft;
     public string fight;
     public string violation;
     public string place;
     public int time;
     public string police;
     public Utryckning(string theft, string fight, string violation, string place, int time, string police)
     {
         this.theft = theft;
         this.fight = fight;
         this.violation = violation;
         this.place = place;
         this.time = time;
         this.police = police;
     }
 }
 class Report
 {
     //skapar en lista så vi kan spara värdena
     List<Report> report = new List<Report>();
     //skapar egenskaper för rapportnummer, datum, polisstation, beskrivning
     public int reportNumber;
     public int date;
     public string policestation;
     public string description;
     public Report(int reportNumber, int date, string policestation, string description)
     {
         this.reportNumber = reportNumber;
         this.date = date;
         this.policestation = policestation;
         this.description = description;
     }
 }
 class Personel
 {
     //skapar en lista så vi kan spara värdena
     List<Personel> personel = new List<Personel>();
     //skapar egenskaper för polisernas namn, tjänstenummer
     public string lastName;
     public int serviceNumber;
     public Personel(string lastName, int serviceNumber)
     {
         this.lastName = lastName;
         this.serviceNumber = serviceNumber;
     }

 }
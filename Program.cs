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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du kan endast mata in siffor. \nVänligen försök igen");
            }
            //tillfälliga villkor, ska jämföra om tjänstenumret och lösenordet är korrekt
            if (logInNumber == 4)
            {
                //skapar listor för personal, rapporter och utryckningar
                List<Personel> personelList = new List<Personel>();
                List<Report> reports = new List<Report>();
                List<Utryckning> departure = new List<Utryckning>();
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
                                Utryckning.RegisterUtryckning();
                                break;
                            case 2:
                                Report.RegisterReports(reports);
                                break;
                            case 3:
                                Personel.AddPersonel(personelList);
                                break;
                            case 4:
                                PrintInformation();
                                break;
                            case 5:
                                Console.WriteLine("Du loggas nu ut..");
                                Thread.Sleep(1500);
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
        }
        static void PrintInformation()
        {
            //skriva ut information om utryckningar, rapporter och personal
            //i informationen ska allt tillsammans skriva ut.
            //vill få tillgång till alla listorna här. ska väl inte behöva skapa i varje klass?
            //detta ska upptaderas så vi kan använda denna till olika branscher

        }
    }
    public class Utryckning
    {
        //sätter egenskaper för brott, stöld, bråk, trafikbrott
        //sätter egenskaper för plats, tidpunkt, poliser
        public string theft;
        public string fight;
        public string violation;
        public string place;
        public float time;
        public string police;
        public Utryckning(string theft, string fight, string violation, string place, float time, string police)
        {
            this.theft = theft;
            this.fight = fight;
            this.violation = violation;
            this.place = place;
            this.time = time;
            this.police = police;
        }
        public static void RegisterUtryckning()
        {
            //metod för att registrera utryckningarna
            //detta ska upptaderas så vi kan använda denna till olika branscher
            //lägga in null ifall det inte är alla alternativen
            Console.WriteLine("Vilket typ av brott gäller det?");

        }
    }
    public class Report
    {
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
        public static void RegisterReports(List<Report> addReport)
        {
            Report registerReport = new Report(0,0,"","");
            //metod för att fylla i rapporter
            //detta ska upptaderas så vi kan använda denna till olika branscher
            //kan vi göra det här på ett smidigare sätt?
            Console.WriteLine("Fyll i din rapport för utryckningen: ");
            Console.WriteLine("Rapportnumret: ");
            int number = int.Parse(Console.ReadLine());
            registerReport.reportNumber = number;
            Console.WriteLine("Dagens datum: ");
            int todaysDate = int.Parse(Console.ReadLine());
            registerReport.date = todaysDate;
            Console.WriteLine("Polisstationen som tog emot ärdendet: ");
            string policeStation = Console.ReadLine();
            registerReport.policestation = policeStation;
            Console.WriteLine("Skriv en kort sammanfattning om fallet: ");
            string summary = Console.ReadLine();
            registerReport.description = summary;
            addReport.Add(registerReport);    
        }
    }
    public class Personel
    {
        //skapar egenskaper för polisernas namn, tjänstenummer
        public string firstName;
        public string lastName;
        public int serviceNumber;
        public Personel(string firstName, string lastName, int serviceNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.serviceNumber = serviceNumber;
        }

        public static void AddPersonel(List<Personel> addPerson)
        {
            //lägg till personal
            //detta ska upptaderas så vi kan använda denna till olika branscher
            Personel addNewPerson = new Personel("name", "lastname", 0);

            Console.WriteLine("Den nya anställdas förnamn: ");
            string addFirstName = Console.ReadLine();
            addNewPerson.firstName = addFirstName;
            Console.WriteLine("Efternamn: ");
            string addLastName = Console.ReadLine();
            addNewPerson.lastName = addLastName;
            Console.WriteLine("Tjänstenummer: ");
            int number = int.Parse(Console.ReadLine());
            addNewPerson.serviceNumber = number;
            addPerson.Add(addNewPerson);

            Console.WriteLine($"Du har lagt till {addNewPerson.firstName} {addNewPerson.lastName} med tjänstenummer: {addNewPerson.serviceNumber}");
        }
    }
}
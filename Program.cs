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
                //Console.Clear();

                if (logInNumber == 4)
                {
                    while (true)
                    {
                        //"undermenyn" där polisen får skriva rapporter mm
                        //här ska namnet på personen som loggade in stå.
                        //Lägg till en super admin som kan gå in och ändra precis vad dom vill som är kodat,
                        //t.ex. lägga till stationer, ändra lösenord, ändra personal info, ändra i rapporter.
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
                                Report.RegisterReports();
                                break;
                            case 3:
                                Personel.AddPersonel();
                                break;
                            case 4:
                                PrintAllInformation();
                                break;
                            case 5:
                                Console.WriteLine("Du loggas nu ut..");
                                Thread.Sleep(1500);
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
            }
            //tillfälliga villkor, ska jämföra om tjänstenumret och lösenordet är korrekt
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Du kan endast mata in siffor. \nVänligen försök igen");
            }
        }
        static void PrintAllInformation()
        {
            //här vill jag anropa metoderna från dem andra klasserna 
            //ska få detta att fungera med en inloggning från olika branscher
            //om listorna är tomma ska detta skrivas ut, tryparse?
            Console.WriteLine("Vilken lista vill du komma åt?");
            Console.WriteLine("1. Lista över utryckningar \n2. Lista över rapporter \n3. Lista över personal");
            int listChoice = int.Parse(Console.ReadLine());
            if (listChoice == 1)
            {
                Utryckning.PrintUtryckning();
            }
            if (listChoice == 2)
            {
                Report.PrintReport();
            }
            if (listChoice == 3)
            {
                Personel.PrintPerson();
            }
        }
    }
    public class Utryckning
    {
         public static List<Utryckning> departure = [];
        //sätter egenskaper för brott, stöld, bråk, trafikbrott
        //sätter egenskaper för plats, tidpunkt, poliser
        public string crime;
        public string place;
        public DateTime time;
        public string police;
        public Utryckning(string crime, string place, DateTime time, string police)
        {
            this.crime = crime;
            this.place = place;
            this.time = time;
            this.police = police;
        }
        public static void RegisterUtryckning()
        {
            Utryckning addUtryckning = new("", "", DateTime.Now, "");
            //metod för att registrera utryckningarna
            //detta ska upptaderas så vi kan använda denna till olika branscher
            //lägga in null ifall det inte är alla alternativen
            Console.WriteLine("Vilket typ av brott gäller det?");
            Console.Write("Stöld, Slagsmål, Trafik:  ");
            string typeOfCrime = Console.ReadLine().ToLower();
            Console.Write("Vart tog händelsen plats: ");
            string placeOfCrime = Console.ReadLine();
            Console.Write("Utryckande polis tjänstenummer: ");
            string policeOfficer = Console.ReadLine();
            addUtryckning = new Utryckning(typeOfCrime, placeOfCrime, DateTime.Now, policeOfficer);
            departure.Add(addUtryckning);
            Console.WriteLine($"Du har lagt till: {typeOfCrime} {placeOfCrime} {DateTime.Now}");
        }
        public static void PrintUtryckning()
        {
            foreach (Utryckning list in departure)
            {
                Console.WriteLine($"Brottet som begåtts {list.crime}. Platsen där händelsen inträffade {list.place}. Tiden då brottet begicks{list.time}. Polisen som svarade på utryckningen {list.police}.");
            }
        }

    }
    public class Report
    {
        public static List<Report> reports = new List<Report>();
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
        public static void RegisterReports()
        {
            Report registerReport = new Report(0, 0, "", "");
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
            reports.Add(registerReport);
        }
        public static void PrintReport()
        {
            //skriva ut information om utryckningar, rapporter och personal
            //i informationen ska allt tillsammans skriva ut.
            //vill få tillgång till alla listorna här. ska väl inte behöva skapa i varje klass?
            //detta ska upptaderas så vi kan använda denna till olika branscher
            Console.WriteLine("Skriver ut rapporterna");
            foreach (Report report in reports)
            {
                Console.WriteLine($"Rapportnumret {report.reportNumber}. Datum{report.date}. Polistationen som{report.policestation} {report.description}");
            }
        }
    }
    public class Personel
    {

        //lägga till en klass för polis station så att de kan välja vilken station de tillhör och sedan sin personal info.
        public static List<Personel> personelList = new List<Personel>();
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

        public static void AddPersonel()
        {
            //lägg till personal
            //detta ska upptaderas så vi kan använda denna till olika branscher
            Personel addNewPerson = new Personel("", "", 0);

            Console.WriteLine("Den nya anställdas förnamn: ");
            string addFirstName = Console.ReadLine();
            addNewPerson.firstName = addFirstName;
            Console.WriteLine("Efternamn: ");
            string addLastName = Console.ReadLine();
            addNewPerson.lastName = addLastName;
            Console.WriteLine("Tjänstenummer: ");
            int number = int.Parse(Console.ReadLine());
            addNewPerson.serviceNumber = number;
            personelList.Add(addNewPerson);

            Console.WriteLine($"Du har lagt till {addFirstName} {addLastName} med tjänstenummer: {number}");
        }
        public static void PrintPerson()
        {
            //skriver ut personal
            foreach (Personel printPerson in personelList)
            {
                Console.WriteLine($"Den anställdes namn: {printPerson.firstName} {printPerson.lastName} Den anställdas tjänstenummer: {printPerson.serviceNumber}");
            }
        }
    }
}
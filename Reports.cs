namespace Polisen
{
    public class Report
    {
        //skapar egenskaper för rapportnummer, datum, polisstation, beskrivning
        public static List<Report> reports = new List<Report>();
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

        public static void RegisterReport()
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
}
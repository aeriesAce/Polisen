namespace Polisen
{
    public class Report
    {
        //skapar egenskaper för rapportnummer, datum, polisstation, beskrivning
        public static List<Report> reportList = new List<Report>();
        public int reportNumber;
        public DateTime date;
        public string policestation;
        public string description;
        public Report(int reportNumber, DateTime date, string policestation, string description)
        {
            this.reportNumber = reportNumber;
            this.date = date;
            this.policestation = policestation;
            this.description = description;
        }

        public void RegisterReport()
        {
            //metod för att fylla i rapporter
            //detta ska upptaderas så vi kan använda denna till olika stationer
            Console.WriteLine("Fyll i din rapport för utryckningen: ");
            Console.WriteLine("Rapportnumret: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Polisstationen som tog emot ärdendet: ");
            string policeStation = Console.ReadLine();
            Console.WriteLine("Skriv en kort sammanfattning om fallet: ");
            string summary = Console.ReadLine();
            Report registerReport = new Report(number, DateTime.Now, policeStation, summary);
            reportList.Add(registerReport);

            Console.WriteLine($"Du har lagt till en rapport med rapportnummer {number}");
        }

        public static void PrintReport()
        {
            //skriva ut information om utryckningar, rapporter och personal
            //i informationen ska allt tillsammans skriva ut.
            //vill få tillgång till alla listorna här. ska väl inte behöva skapa i varje klass?
            //detta ska upptaderas så vi kan använda denna till olika stationer
            Console.WriteLine("Skriver ut rapporterna");
            foreach (Report report in reportList)
            {
                Console.WriteLine($"Rapportnummer: {report.reportNumber}. Datum:{report.date}. Polistationen som tog emot ärendet: {report.policestation}, {report.description}");
            }
        }
    }
}
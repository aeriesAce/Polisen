namespace Polisen
{
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

    //-----VAD VI BEHÖVER LÖSA------//
    /*Vi behöver ändra metoder och listor till endast public och ta bort static
      Vi behöver lägga listorna i antingen main metoden eller i en super klass där vi hanterar dem. INTE där dem ligger nu
      Vi behöver använda oss av faktiska personer, tex station, istället för att anropa string så anropar vi typen från klassen.
      Vi behöver ändra i menyerna. Behöver vi båda? Tror inte det, bästa är att kanske bara ha en vanlig inloggning innan.
      Vi behöver lägga in felhantering mer smidigt i koden, nu har vi endast i menyn, antingen att vi börjar använda oss av Try-parse eller null.
      Vi behöver lägga till en super admin som kan gå in och ändra precis vad dom vill som är kodat,???
      Vi behöver lägga till stationer, ändra lösenord, ändra personal info, ändra i rapporter.
      Vi behöver kolla på redundans, men tänker att vi gör det när vi känner oss klara med resten så jobbar vi oss ner steg för steg.
      Vad som behöver jobbas med: Klasserna, adda metoderna, utskrifterna mm
      När vi har ändrat det som står här så tar vi bara bort raden <3.
      */
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel("Pelle", "Olsson", 4477);
            Personel personel2 = new Personel("Saga", "Johansson", 5511);
            Personel.personelList.Add(personel);
            Personel.personelList.Add(personel2);
            //istället för att skriva in personal ska stationerna vi har lagt in användas.
            Report reports = new Report(10, DateTime.Now, "Stockholm Polisstation", "Våldsam man vid kvinnornas underkläder");
            Report reports2 = new Report(10, DateTime.Now, "Malmö Centrala", "Kvinna hotade man utanför Hemköp.");
            Report.reportList.Add(reports);
            Report.reportList.Add(reports2);
            Utryckning utryckning = new Utryckning("Stöld", "Kristianstad", DateTime.Now, 4488);
            Utryckning utryckning2 = new Utryckning("Slagsmål", "Uddevalla", DateTime.Now, 8877);
            Utryckning.departureList.Add(utryckning);
            Utryckning.departureList.Add(utryckning2);
            int logInNumber = 0;
            int logInPassword = 0;

            //Rickard jag skrev om menyn, istället för att ha en massa while loopar mm så la jag allt i samma.
            //huvudmenyn där polisen loggar in
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------Huvudmenyn------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ange ditt Tjänstenummer: ");
            logInNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ditt lösenord: ");
            logInPassword = int.Parse(Console.ReadLine());
            while (true)
            {
                try
                {
                    //Console.Clear();  Den stoppar debuggingen, tar tillbaka när vi inte behöver längre
                    if (logInNumber == 4)
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
                                utryckning.RegisterUtryckning();
                                break;
                            case 2:
                                reports.RegisterReport();
                                break;
                            case 3:
                                personel.AddPersonel();
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
                    else
                    {
                        //om användaren loggar in med fel lösenord/användarnamn
                        //vi ska kunna hantera
                        Console.WriteLine("Fel lösenord/användarlogin, försök igen.");
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du kan endast mata in siffor. \nVänligen försök igen");
                }
            }
        }

        static void PrintAllInformation()
        {
            //här vill jag anropa metoderna från dem andra klasserna 
            //ska få detta att fungera med en inloggning från olika stationer
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
}
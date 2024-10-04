namespace Polisen
{
    public class Personel
    {
        //lägga till en klass för polis station så att de kan välja vilken station de tillhör och sedan sin personal info.
        //skapar egenskaper för polisernas namn, tjänstenummer
        public static List<Personel> personelList = new List<Personel>();
        public string firstName;
        public string lastName;
        public int serviceNumber;
        public Personel(string firstName, string lastName, int serviceNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.serviceNumber = serviceNumber;
        }

        public void AddPersonel()
        {
            //lägg till personal
            //detta ska upptaderas så vi kan använda denna till olika stationer
            Console.WriteLine("Den nya anställdas förnamn: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Tjänstenummer: ");
            int serviceNumber = int.Parse(Console.ReadLine());
            Personel addNewPerson = new Personel(firstName, lastName, serviceNumber);
            personelList.Add(addNewPerson);

            Console.WriteLine($"Du har lagt till {firstName} {lastName} med tjänstenummer: {serviceNumber}");
        }

        public static void PrintPerson()
        {
            //Vi vill skriva ut personer som tillhör olika stationer.
            //tex ska pelle bara skrivas ut från göteborgs inlogg

            //skriver ut personal
            foreach (Personel printPerson in personelList)
            {
                Console.WriteLine($"Den anställdes namn: {printPerson.firstName} {printPerson.lastName} Tjänstenummer: {printPerson.serviceNumber}");
            }
        }
    }
}
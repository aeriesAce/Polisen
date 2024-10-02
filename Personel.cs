namespace Polisen
{
    public class Personel
    {
        //lägga till en klass för polis station så att de kan välja vilken station de tillhör och sedan sin personal info.
        //skapar egenskaper för polisernas namn, tjänstenummer
        public List<Personel> personelList = new List<Personel>();
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
            //detta ska upptaderas så vi kan använda denna till olika branscher
            Console.WriteLine("Den nya anställdas förnamn: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Tjänstenummer: ");
            int serviceNumber = int.Parse(Console.ReadLine());
            Personel addNewPerson = new Personel(this.firstName, this.lastName, this.serviceNumber);
            personelList.Add(addNewPerson);

            Console.WriteLine($"Du har lagt till {firstName} {lastName} med tjänstenummer: {serviceNumber}");
        }

        public void PrintPerson()
        {
            //skriver ut personal
            foreach (Personel printPerson in personelList)
            {
                Console.WriteLine($"Den anställdes namn: {printPerson.firstName} {printPerson.lastName} Den anställdas tjänstenummer: {printPerson.serviceNumber}");
            }
        }
    }
}
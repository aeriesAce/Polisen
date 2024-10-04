namespace Polisen
{
    public class Utryckning
    {
        //sätter egenskaper för brott, stöld, bråk, trafikbrott
        //sätter egenskaper för plats, tidpunkt, poliser
        public static List<Utryckning> departureList = new List<Utryckning>();
        public string crime;
        public string place;
        public DateTime time;
        public int police;
        public Utryckning(string crime, string place, DateTime time, int police)
        {
            this.crime = crime;
            this.place = place;
            this.time = time;
            this.police = police;
        }

        public void RegisterUtryckning()
        {
            //metod för att registrera utryckningarna
            //detta ska upptaderas så vi kan använda denna till olika stationer
            //lägga in fel ifall användaren råkar lämna en ruta blank
            //lägga in så att man kan välja polis som faktiskt finns i listan och en kontroll ifall polisen inte existerar.
           while(true)
           {
             Console.WriteLine("Vilket typ av brott gäller det?");
            Console.Write("Stöld, Slagsmål, Trafikstörning:  ");
            string typeOfCrime = Console.ReadLine().ToLower();
            Console.Write("Vart tog händelsen plats: ");
            string placeOfCrime = Console.ReadLine();
            Personel.PrintPerson();
            Console.Write("Utryckande polis tjänstenummer: ");
            int policeOfficer = int.Parse(Console.ReadLine());
            Utryckning addUtryckning = new Utryckning(typeOfCrime, placeOfCrime, DateTime.Now, policeOfficer);
            departureList.Add(addUtryckning);
            Console.WriteLine($"Du har lagt till: {typeOfCrime} {placeOfCrime} {DateTime.Now}");

            if(policeOfficer != Personel.personelList.Count)
            {
                Console.WriteLine("Det finns ingen personal med det utryckningsnumret.");
            }
           }
        }
        public static void PrintUtryckning()
        {
            foreach (Utryckning list in departureList)
            {
                Console.WriteLine($"Brottet som begåtts: {list.crime}. Platsen där händelsen inträffade: {list.place}. Tiden då brottet begicks: {list.time}. Polisen som svarade på utryckningen: {list.police}.");
            }
        }
    }
}

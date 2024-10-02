namespace Polisen
{
    public class Utryckning
    {
        //sätter egenskaper för brott, stöld, bråk, trafikbrott
        //sätter egenskaper för plats, tidpunkt, poliser
        public static List<Utryckning> departure = [];
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
}

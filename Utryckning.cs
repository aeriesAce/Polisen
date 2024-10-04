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

namespace Polisen
{
    /*här ska polisstaionerna hanteras
    Vi behöver:
    Inloggning för varje polisstation, börjar med 1.
    Hantera listor för personal, utryckning och rapporter som tillhör SPECIFIK station 
    para inloggen i en klass??? och sen checka av till vilken brancsh personen tillhör.
    Dem 4 första siffrorna är kopplat till en specifik brancsh.*/
    class Policestation
    {
        /*ska vi arbeta med arv så borde det kanske egentligen skrivas här,
        saker som är specifika ska tilldelas i subklassen. Men saker som tex namn kan/ska tilldelas här.
        så egentligen ska det nog se ut såhär:*/
        public string stationName;
        public int stationNumber;
        public Policestation(string stationName, int stationNumber)
        {
            this.stationName = stationName;
            this.stationNumber = stationNumber;
        }

        class GothenburgStation : Policestation
        {
            //exempel klass
            /*Skapar arv av polisstationerna. vet ej om det här är det bästa sättet att jobba på just nu.
             Vi kanske behöver skriva om i dem andra klasserna om vi gör såhär, kanske tom lägga till alla egenskaper i Policestation klassen,
             osäker på bästa lösningen..*/
            int stationLogIn = 4444; //inlogg för att komma åt GÖTEBORGS LISTOR mm
            public GothenburgStation(string stationName, int stationNumber, int stationLogIn)
            :base(stationName, stationNumber)
            {
                this.stationLogIn = stationLogIn;
            }
        }
    }
    
}
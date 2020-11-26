namespace Cwiczenie04
{
    public class Roza : Roslina
    {
        public Roza(string imie, double wysokosc) : base(imie, wysokosc)
        {
        }

        public Roza(string imie, double wysokosc, int iloscWytwarzanegoTlenu, Stan stan) : base(imie, wysokosc, iloscWytwarzanegoTlenu, stan)
        {
        }
    }
}
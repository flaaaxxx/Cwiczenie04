namespace Cwiczenie04
{
    public class Stokrotka : Roslina
    {
        public Stokrotka(string imie, double wysokosc) : base(imie, wysokosc)
        {
        }

        public Stokrotka(string imie, double wysokosc, int iloscWytwarzanegoTlenu, Stan stan) : base(imie, wysokosc, iloscWytwarzanegoTlenu, stan)
        {
        }
    }
}
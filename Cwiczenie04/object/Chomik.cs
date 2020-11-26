using System;

namespace Cwiczenie04
{
    public class Chomik : Zwierze, IRoslinozerne
    {
        public Chomik(string imie, double wysokosc, int szybkosc) : base(imie, wysokosc, szybkosc)
        {
        }

        public void ZnajdzPozywienie()
        {
            Console.WriteLine("Chomik.ZnajdzPozywienie() " + Imie + " znalazł sałatę.");
        }

        public void ZjedzRosline()
        {
            Console.WriteLine("Chomik.ZjedzRosline() " + Imie + " zjadł sałatę.");
        }
    }
}
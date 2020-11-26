using System;

namespace Cwiczenie04
{
    public class Pies : Zwierze, IRoslinozerne, IMiesozerne
    {
        public Pies(string imie, double wysokosc, int szybkosc) : base(imie, wysokosc, szybkosc)
        {
        }

        void IRoslinozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Pies.IRoslinozerne.ZnajdzPozywienie() " + Imie + " znalazł marchewkę.");
        }

        public void ZjedzMieso()
        {
            Console.WriteLine("Pies.ZjedzMiesoe() " + Imie + " zjadł mięso.");
        }

        public void ZjedzRosline()
        {
            Console.WriteLine("Pies.ZjedzRosline() " + Imie + " zjadł marchewkę.");
        }

        void IMiesozerne.ZnajdzPozywienie()
        {
            Console.WriteLine("Pies.IMiesozerne.ZnajdzPozywienie() " + Imie + " znalazł mięso.");
        }
    }
}
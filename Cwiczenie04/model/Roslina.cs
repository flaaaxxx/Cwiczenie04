using System;

namespace Cwiczenie04
{
    public class Roslina : Istota, IRosnace, IRoslinowate
    {
        private double iloscWytwarzanegoTlenu { get; set; }
        private Stan stan { get; set; }

        public Roslina(string imie, double wysokosc) : base(imie, wysokosc)
        {
        }

        public Roslina(string imie, double wysokosc, int iloscWytwarzanegoTlenu, Stan stan) : base(imie, wysokosc)
        {
            this.iloscWytwarzanegoTlenu = iloscWytwarzanegoTlenu;
            this.stan = stan;
        }
        
        
        void IRosnace.Rosnij()
        {
            wysokosc += iloscWytwarzanegoTlenu * 0.1;
            Console.WriteLine("Roślina.IRosnace.Rosnij() - wysokość: " + wysokosc);
        }
        
        void IRoslinowate.Rosnij()
        {
            wysokosc += iloscWytwarzanegoTlenu * 0.1;
            Console.WriteLine("Roślina.IRoslinowate.Rosnij() - wysokość: " + wysokosc);
        }

        public void Zakwitnij()
        {
            Console.WriteLine("Roślina.Zakwitnij()");
        }

        public void Owocuj()
        {
            Console.WriteLine("Roślina.Owocuj()");
        }
    }
}
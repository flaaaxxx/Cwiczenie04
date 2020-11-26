using System;
using Cwiczenie04.exception;

namespace Cwiczenie04
{
    public class Zwierze : Istota, ICloneable
    {
        private int szybkosc;

        public Zwierze(string imie, double wysokosc, int szybkosc) : base(imie, wysokosc)
        {
            this.szybkosc = szybkosc;
        }

        public int Szybkosc
        {
            get => szybkosc;
            set
            {
                if (value < 1225)
                    szybkosc = value;
                else
                    throw new SzybkoscException("Predkość przekroczyła barierę dzwięku!!!");
            }
        }

        public void Rosnij()
        {
            wysokosc += wysokosc * 0.3;
            Console.WriteLine("Zwierzę.Rosnij() - wysokość: " + wysokosc);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
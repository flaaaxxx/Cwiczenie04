using System;
using Cwiczenie04.exception;

namespace Cwiczenie04
{
    public class Duch : Istota
    {
        private int przezroczystosc;
        private int iloscEktoplazmy { get; set; }

        public void JakStraszyc(string straszenie)
        {
            Console.WriteLine("Metoda straszenia: " + straszenie);
        }

        public Duch(string imie, double wysokosc) : base(imie, wysokosc)
        {
        }

        public int Przezroczystosc
        {
            get => przezroczystosc;
            set
            {   
                if (value > 0 && value < 100)
                    przezroczystosc = value;
                else
                {
                    throw new PrzezroczystoscException("Zły zakres!!!");
                }
            }
        }
    }
}
using System;

namespace Cwiczenie04
{
    public class Samochod
    {
        private string model;
        private double cena;

        public Samochod()
        {
        }

        public Samochod(string model, double cena)
        {
            this.model = model;
            this.cena = cena;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double Cena
        {
            get => cena;
            set => cena = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
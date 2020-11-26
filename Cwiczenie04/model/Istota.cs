namespace Cwiczenie04
{
    public class Istota
    {
        private string imie;
        protected double wysokosc;

        public Istota(string imie, double wysokosc)
        {
            this.imie = imie;
            this.wysokosc = wysokosc;
        }

        public string Imie
        {
            get => imie;
            set => imie = value;
        }

        public double Wysokosc
        {
            get => wysokosc;
            set => wysokosc = value;
        }
    }
}
namespace Cwiczenie04
{
    public class Dom
    {
        private double powierzchnia;
        private double cena;

        public Dom() { }

        public Dom(double powierzchnia, double cena)
        {
            this.powierzchnia = powierzchnia;
            this.cena = cena;
        }

        public double Powierzchnia
        {
            get => powierzchnia;
            set => powierzchnia = value;
        }

        public double Cena
        {
            get => cena;
            set => cena = value;
        }
    }
}
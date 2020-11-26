using System.Collections;

namespace Cwiczenie04.comparer
{
    public class CzlowieSuma : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Czlowiek czlowiek1 = (Czlowiek) x;
            Czlowiek czlowiek2 = (Czlowiek) y;

            double sumaDomyCzlowiek1 = 0;
            double sumaDomyCzlowiek2 = 0;
            double sumaSamochodyCzlowiek1 = 0;
            double sumaSamochodyCzlowiek2 = 0;

            foreach (Dom dom in czlowiek1.Domy)
            {
                sumaDomyCzlowiek1 += dom.Cena;
            }

            foreach (Dom dom in czlowiek2.Domy)
            {
                sumaDomyCzlowiek2 += dom.Cena;
            }

            foreach (Samochod samochod in czlowiek1.Samochody)
            {
                sumaSamochodyCzlowiek1 += samochod.Cena;
            }

            foreach (Samochod samochod in czlowiek1.Samochody)
            {
                sumaSamochodyCzlowiek2 += samochod.Cena;
            }

            if (sumaSamochodyCzlowiek1 + sumaDomyCzlowiek1 < sumaSamochodyCzlowiek2 + sumaDomyCzlowiek2)
                return -1;
            else if (sumaSamochodyCzlowiek1 + sumaDomyCzlowiek1 > sumaSamochodyCzlowiek2 + sumaDomyCzlowiek2)
                return 1;
            else return 0;
        }
    }
}
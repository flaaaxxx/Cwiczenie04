using System.Collections;

namespace Cwiczenie04.comparer
{
    public class CzlowiekIloscDomow : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Czlowiek czlowiek1 = (Czlowiek) x;
            Czlowiek czlowiek2 = (Czlowiek) y;

            if (czlowiek1.Domy.Length < czlowiek2.Domy.Length)
                return -1;
            else if (czlowiek1.Domy.Length > czlowiek2.Domy.Length)
                return 1;
            else return 0;
        }
    }
}

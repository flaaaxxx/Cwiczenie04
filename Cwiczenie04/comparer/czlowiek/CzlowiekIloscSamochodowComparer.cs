using System;
using System.Collections;
using System.Collections.Generic;

namespace Cwiczenie04.comparer
{
    public class CzlowiekIloscSamochodowComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Czlowiek czlowiek1 = (Czlowiek) x;
            Czlowiek czlowiek2 = (Czlowiek) y;

            if (czlowiek1.Samochody.Length < czlowiek2.Samochody.Length)
                return -1;
            else if (czlowiek1.Samochody.Length > czlowiek2.Samochody.Length)
                return 1;
            else return 0;
        }
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using Cwiczenie04.comparer;

namespace Cwiczenie04
{
    public class Czlowiek : Zwierze, IEnumerable, IComparable
    {
        private int ilorazInteligencji;
        private Samochod[] samochody;
        private Dom[] domy;

        public Czlowiek(string imie, double wysokosc, int szybkosc, int ilorazInteligencji, Samochod[] samochody, Dom[] domy) : base(imie, wysokosc, szybkosc)
        {
            this.ilorazInteligencji = ilorazInteligencji;
            this.samochody = samochody;
            this.domy = domy;
        }

        public Samochod[] Samochody
        {
            get => samochody;
            set => samochody = value;
        }

        public int IlorazInteligencji
        {
            get => ilorazInteligencji;
            set => ilorazInteligencji = value;
        }

        public int IlorazInteligencji1
        {
            get => ilorazInteligencji;
            set => ilorazInteligencji = value;
        }

        public Samochod[] Samochody1
        {
            get => samochody;
            set => samochody = value;
        }

        public Dom[] Domy
        {
            get => domy;
            set => domy = value;
        }

        public double Wysokosc1
        {
            get => wysokosc;
            set => wysokosc = value;
        }


        public IEnumerator GetEnumerator()
        {
            return samochody.GetEnumerator();
        }

        public IEnumerable<Dom> GetDomy(double cena = 0)
        {
            foreach (Dom dom in domy)
            {
                if (dom.Cena > cena)
                {
                    yield return dom;
                }
               
            }
        }

        // public object Clone()
        // {
        //     Czlowiek czlowiek = (Czlowiek)this.MemberwiseClone();
        //     List<Samochod> samochodList = new List<Samochod>();
        //     List<Samochod> nowaSamochodList = new List<Samochod>(samochodList.Count);
        //
        //     samochodList.ForEach((item)=>
        //     {
        //         nowaSamochodList.Add(new Samochod(item.Model, item.Cena));
        //     });
        //
        //     czlowiek.samochody = nowaSamochodList;
        //     
        //     List<Dom> domList = new List<Dom>();
        //     List<Dom> nowyDomList = new List<Dom>(domList.Count);
        //
        //     domList.ForEach((item)=>
        //     {
        //         nowyDomList.Add(new Dom(item.Powierzchnia, item.Cena));
        //     });
        //
        //     czlowiek.domy = nowyDomList;
        //
        //     return czlowiek;
        // }
        //
        public int CompareTo(object? obj)
        {
            Czlowiek czlowiek = (Czlowiek) obj;
            if (this.ilorazInteligencji > czlowiek.ilorazInteligencji)
            {
                return 1;
            }
        
            if (this.ilorazInteligencji < czlowiek.ilorazInteligencji)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        // public static IComparer SortByCarsCount
        // {
        //     get
        //     {
        //         return (IComparer) new CzlowiekIloscSamochodowComparer();
        //     } 
        // }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Cwiczenie04.comparer;
using Cwiczenie04.exception;

namespace Cwiczenie04
{
    class Program
    {
        static List<Istota> istotaList = new List<Istota>();
        static List<IRoslinozerne> roslinozerneList = new List<IRoslinozerne>();
        static List<IMiesozerne> miesozerneList = new List<IMiesozerne>();
        static List<Czlowiek> czlowiekList = new List<Czlowiek>();
        static Czlowiek[] czlowiekArray = new Czlowiek[3];

        static void Main(string[] args)
        {
            istotaList.Add(new Casper("Casper", 50));
            istotaList.Add(new Jin("Jin", 60));
            istotaList.Add(new Roza("Czerwona", 25, 33, Stan.ROSNIE));
            istotaList.Add(new Stokrotka("Polna", 15, 10, Stan.ZAKWITA));

            roslinozerneList.Add(new Chomik("Chomiczek", 7, 23));
            roslinozerneList.Add(new Chomik("Chomiczka", 8, 24));

            miesozerneList.Add(new Pies("Leos", 30, 49));
            miesozerneList.Add(new Pies("Kropka", 60, 50));

            try
            {
                UtworzNoweIstoty();
            }
            catch (SzybkoscException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PrzezroczystoscException e)
            {
                Console.WriteLine(e.Message);
            }

            PrzepiszRoslinozerne(istotaList);
            PrzepiszMiesozerne(istotaList);

            // foreach (Istota el in roslinozerneList)
            // {
            //     Console.WriteLine(el.Imie);
            // }
            // Console.WriteLine("--------------------------------");
            // foreach (Istota el in miesozerneList)
            // {
            //     Console.WriteLine(el.Imie);
            // }


            Console.WriteLine("--------------------------------");
            Console.WriteLine("Pora karmienia dla wszyskich");
            KarmienieWszystkich();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Karmienie indywidualne");
            Karmienie(istotaList.ElementAt(2));
            Console.WriteLine("--------------------------------");
            
            // zadania 3.5
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Czlowiek");
            Console.WriteLine("--------------------------------");

            DodajCzlowieka();
            
            // foreach (Istota istota in istotaList) 
            // {
            //     if (istota is Czlowiek)
            //     {
            //         Console.WriteLine("Lista samochodów " + istota.Imie);
            //         foreach (Samochod samochod in ((Czlowiek)istota).Samochody)
            //         {
            //             Console.WriteLine("Model: " + samochod.Model + " Cena: " + samochod.Cena);   
            //         }
            //     }
            // }


            int indeks = 0;
            Czlowiek czlowiek;
            foreach(var istota in istotaList)
            {
                if(istota is Czlowiek)
                {
                    czlowiekList.Add((Czlowiek)istota);
                    czlowiekArray[indeks++] = (Czlowiek)istota;
                }
            }

            // iteracaja po samochodach
            Console.WriteLine("---------------------------");
            Console.WriteLine("Samochody");
            foreach (var c in czlowiekArray)
            {
                foreach (var samochod in c)
                {
                    Console.WriteLine("Model: " + ((Samochod)samochod).Model+ " Cena: " + ((Samochod)samochod).Cena); 
                }
            }
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Domy");
            foreach (var c in czlowiekArray)
            {
                foreach (Dom dom in c.GetDomy(400000))
                {
                    Console.WriteLine("Powierdzchnia: " + dom.Powierzchnia+ " Cena: " + dom.Cena); 
                }
            }
            
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("Sortowanie przed - iloraz inteligencji");
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " iloraz: " + c.IlorazInteligencji1);
            }
            
            Console.WriteLine("Sortowanie po - iloraz");
            Array.Sort(czlowiekArray);
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " iloraz: " + c.IlorazInteligencji1);
            }
            
            Console.WriteLine("Sortowanie przed - ilosc samochodow");
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " ilość samochodów: " + c.Samochody.Length);
            }
            
            Console.WriteLine("Sortowanie po - ilosc samochodow");
            Array.Sort(czlowiekArray, new CzlowiekIloscSamochodowComparer());
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " ilość samochodów: " + c.Samochody.Length);
            }
            
            Console.WriteLine("Sortowanie przed - ilosc domów");
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " ilość domów: " + c.Domy.Length);
            }
            
            Console.WriteLine("Sortowanie po - ilosc domów");
            Array.Sort(czlowiekArray, new CzlowiekIloscDomow());
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " ilość domów: " + c.Domy.Length);
            }
            
            
            Console.WriteLine("Sortowanie przed - suma cen domów i samochodów");
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie + " ilość domów: " + c.Domy.Length);
            }
            
            Console.WriteLine("Sortowanie po - suma cen domów i samochodów");
            Array.Sort(czlowiekArray, new CzlowieSuma());
            foreach (var c in czlowiekArray) 
            {
                Console.WriteLine("Imie: " + c.Imie);
            }
            
        }

        static public void UtworzNoweIstoty()
        {
            istotaList.Add(new Casper("Casper2", 50));
            istotaList.Add(new Jin("Jin2", 60));
            istotaList.Add(new Roza("Żółta", 27, 22, Stan.ROSNIE));
            istotaList.Add(new Stokrotka("Różowa", 11, 12, Stan.ZAOWOCWALA));
            istotaList.Add(new Chomik("Chomis", 8, 12));
            istotaList.Add(new Pies("Mika", 71, 11));
        }

        static void 
            PrzepiszRoslinozerne(List<Istota> istotyList)
        {
            for (int i = 0; i < istotyList.Count; i++)
            {
                if (istotyList.ElementAt(i) is IRoslinozerne)
                {
                    roslinozerneList.Add((IRoslinozerne) istotyList.ElementAt(i));

                }
            }

            Console.WriteLine("Ilość roślinożerców: " + roslinozerneList.Count);
        }

        static void PrzepiszMiesozerne(List<Istota> istotyList)
        {
            for (int i = 0; i < istotyList.Count; i++)
            {
                if (istotyList.ElementAt(i) is IMiesozerne)
                {
                    miesozerneList.Add((IMiesozerne) istotyList.ElementAt(i));
                }
            }

            Console.WriteLine("Ilość mięsożerców: " + miesozerneList.Count);
        }

        static void KarmienieWszystkich()
        {
            for (int i = 0; i < miesozerneList.Count; i++)
            {
                miesozerneList.ElementAt(i).ZnajdzPozywienie();
                miesozerneList.ElementAt(i).ZjedzMieso();
            }

            for (int i = 0; i < roslinozerneList.Count; i++)
            {
                roslinozerneList.ElementAt(i).ZnajdzPozywienie();
                roslinozerneList.ElementAt(i).ZjedzRosline();
            }

            Console.WriteLine("Wszyscy nakarmieni.");
        }

        static void Karmienie(Istota istota)
        {
            if (istota is IMiesozerne)
            {
                ((IMiesozerne) istota).ZnajdzPozywienie();
                ((IMiesozerne) istota).ZjedzMieso();
            }

            if (istota is IRoslinozerne)
            {
                ((IRoslinozerne) istota).ZnajdzPozywienie();
                ((IRoslinozerne) istota).ZjedzRosline();
            }

            Console.WriteLine("Istota " + istota.Imie + " nakarmiona.");
        }

        
        
        public static void DodajCzlowieka()
        {
            Samochod[] samochodyArray = new Samochod[4];
            samochodyArray[0] = new Samochod("Opel", 1);
            samochodyArray[1] = new Samochod("Audi A6", 1);
            samochodyArray[2] = new Samochod("Fiat Panda", 1);
            samochodyArray[3] = new Samochod("Fiat Panda", 1);

            Dom[] domArray = new Dom[3];
            domArray[0] = new Dom(200, 1);
            domArray[1] = new Dom(100, 1);
            domArray[2] = new Dom(100, 1);
            
            istotaList.Add(new Czlowiek("Bronislaw", 
                        170,
                        15,
                        80,
                        samochodyArray, 
                        domArray));
            
            
            Samochod[] samochodyArray2 = new Samochod[3];
            samochodyArray2[0] = new Samochod("Audi A6", 200000);
            samochodyArray2[1] = new Samochod("Audi A3", 90000);
            samochodyArray2[2] = new Samochod("Fiat Brava", 4000);
            
            Dom[] domArray2 = new Dom[2];
            domArray2[0] = new Dom(160, 418000);
            domArray2[1] = new Dom(150, 238000);
        
            istotaList.Add(new Czlowiek("Radoslaw", 180, 25, 50,
                samochodyArray2,
                domArray2));
            
            Samochod[] samochodyArray3 = new Samochod[5];
            samochodyArray3[0] = new Samochod("Audi A6", 100000);
            samochodyArray3[1] = new Samochod("Opel", 50000);
            samochodyArray3[2] = new Samochod("Audi A8", 80000);
            samochodyArray3[3] = new Samochod("Audi A7", 10000);
            samochodyArray3[4] = new Samochod("Audi A3", 22000);
            
            
            Dom[] domArray3 = new Dom[1];
            domArray3[0] = new Dom(160, 428000);
            
            istotaList.Add(new Czlowiek("Miroslaw", 180, 25, 70,
                samochodyArray3,
                domArray3));
            
        }
    }
}
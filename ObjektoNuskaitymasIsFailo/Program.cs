using System;

namespace ObjektoNuskaitymasIsFailo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Knyga> knygos = NuskaitytiKnygasIsFailo();

            foreach (Knyga knyga in knygos)
            {
                Console.WriteLine(knyga.Pavadinimas);
            }

        }

        /// <summary>
        ///  Funkcija nuskaito Knyga klasės objektus iš tekstinio failo ir juos išsaugo į Listą.
        /// </summary>
        /// <returns>Grąžina Knyga objektų Listą</returns>
        static List<Knyga> NuskaitytiKnygasIsFailo()
        {
            List<Knyga> knygaList = new List<Knyga>();

            // Nuskaitau kiekvieną tekstinę eilutę iš failo - į string kintamuosius, o jie yra string masyve (tai kiekvienas masyvo elementas yra atskira eilutė)
            string[] eilutes = System.IO.File.ReadAllLines(@"C:\Users\ADFADFDA\Desktop\pamokos6-NET-programavimas\c-sharp-pamokos\pamoka11.objektu-nuskaitymas-is-failo\FailuNuskaitymas\ObjektoNuskaitymasIsFailo\knygu_duomenys.csv");
            
            for (int i = 1; i < eilutes.Length; i++)
            {
                Knyga knyga = KonvertuotiEiluteIKnyga(eilutes[i]);
                knygaList.Add(knyga);
            }
            return knygaList;
        }


        static Knyga KonvertuotiEiluteIKnyga(string eilute)
        {
            Knyga knyga = new Knyga();

            string[] stulpeliai = eilute.Split(',');

            // Sudedu visus stulpelius į atitinkamus Knygos kintamuosoius
            knyga.Isbn = stulpeliai[0];
            knyga.Pavadinimas = stulpeliai[1];
            knyga.Autorius = stulpeliai[2];
            knyga.LeidimoMetai = Convert.ToInt32(stulpeliai[3]);
            knyga.Leidejas = stulpeliai[4];
            knyga.Salis = stulpeliai[5];
            knyga.Kaina = Convert.ToDecimal(stulpeliai[6]);
            

            return knyga;

        }
    }
}
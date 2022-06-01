using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoNuskaitymasIsFailo
{
    internal class Knyga
    {
        // Kintamieji
        private string isbn;
        private string pavadinimas;
        private string autorius;
        private int leidimoMetai;
        private string leidejas;
        private string salis;
        private decimal kaina;

        // Konstruktoriai
        public Knyga(string isbn, string pavadinimas, string autorius, int leidimoMetai, string leidejas, string salis, decimal kaina)
        {
            this.isbn = isbn;
            this.pavadinimas = pavadinimas;
            this.autorius = autorius;
            this.leidimoMetai = leidimoMetai;
            this.leidejas = leidejas;
            this.salis = salis;
            this.kaina = kaina;
        }
        public Knyga()
        {
        }

        // Getteriai setteriai
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Pavadinimas
        {
            get { return pavadinimas; }
            set { pavadinimas = value; }
        }
        public string Autorius
        {
            get { return autorius; }
            set { autorius = value; }
        }
        public int LeidimoMetai
        {
            get { return leidimoMetai; }
            set { leidimoMetai = value; }
        }
        public string Leidejas
        {
            get { return leidejas; }
            set { leidejas = value; }
        }
        public string Salis
        {
            get { return salis; }
            set { salis = value; }
        }
        public decimal Kaina
        {
            get { return kaina; }
            set { kaina = value; }
        }

    }
}

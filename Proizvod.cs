using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace esuspomogiv2
{
    public class Proizvod
    {
        public Proizvod(string naziv, string jedinicaMere, int kolicina, float cena, string slika)
        {
            Naziv = naziv;
            JedinicaMere = jedinicaMere;
            Kolicina = kolicina;
            Cena = cena;
            Slika = slika;
        }
        public Proizvod()
        {
            
        }

        public string Naziv {  get; set; }
        public string  JedinicaMere{ get; set; }
        public int Kolicina {  get; set; }
        public float Cena {  get; set; }
        public string Slika {  get; set; }

        
    }
}
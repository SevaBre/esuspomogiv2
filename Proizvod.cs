using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace esuspomogiv2
{
    public class Proizvod
    {
        public Proizvod(string naziv, string jedinicaMere, string kolicina, string cena, string slika)
        {
            Naziv = naziv;
            JedinicaMere = jedinicaMere;
            Kolicina = kolicina;
            Cena = cena;
            Slika = slika;
        }
        public Proizvod(string naziv, string jedinicaMere, string kolicina, string cena, string slika,string id)
        {
            Naziv = naziv;
            JedinicaMere = jedinicaMere;
            Kolicina = kolicina;
            Cena = cena;
            Slika = slika;
            ID = id;
        }
        public Proizvod()
        {
            
        }

        public string Naziv {  get; set; }
        public string  JedinicaMere{ get; set; }
        public string Kolicina {  get; set; }
        public string Cena {  get; set; }
        public string Slika {  get; set; }
        public string ID {  get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07
{
    class Pracownik
    {
        public string imie;
        public string nazwisko;
        public Kontrakt kontrakt;

        public Pracownik(string imie, string nazwisko, Kontrakt kontrakt)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.kontrakt = kontrakt;
        }
        public Pracownik(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.kontrakt = new Kontrakt();
        }

        public void ZmienKontrakt(Kontrakt nowyKontrakt)
        {
            this.kontrakt = nowyKontrakt;            
        }
        public void ZmienPodstawe(int nowaPodstawa)
        {
            this.kontrakt.podstawaWynagrodzenia = nowaPodstawa;
        }
        public double WysokoscPensji() => this.kontrakt.Pensja();


        public override string ToString()
        {
            return this.imie + " " + this.nazwisko + " " + this.kontrakt.podstawaWynagrodzenia;
        }

        public Pracownik Clone()
        {
            Pracownik kopia = new Pracownik(this.imie,
                   this.nazwisko, this.kontrakt);

            return kopia;
        }
    }
}

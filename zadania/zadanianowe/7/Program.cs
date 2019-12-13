using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07
{
    class Program
    {
        static void WypiszPracownikow(List<Pracownik> pracownicy)
        {
            for(int i = 0; i < pracownicy.Count; i++)
            {
                Console.WriteLine(pracownicy[i].imie + " " + pracownicy[i].nazwisko +
                    " " + pracownicy[i].WysokoscPensji() + " " + pracownicy[i].kontrakt.typKontraktu);
            }
        }
        static List<Pracownik> SortujListe(List<Pracownik> pracownicy, string poCzym = "imie")
        {
            //na leniwo :s
            if (poCzym == "imie")
            {
                List<Pracownik> posortowana = pracownicy.OrderBy(i => i.imie).ToList();
                return posortowana;
            }
            else if(poCzym == "nazwisko")
            {
                List<Pracownik> posortowana = pracownicy.OrderBy(i => i.nazwisko).ToList();
                return posortowana;
            }
            else if(poCzym == "pensja")
            {
                for(int i = 0; i < pracownicy.Count; i++)
                {
                    if (pracownicy[i].kontrakt.typKontraktu == Kontrakt._typKontraktu.staz)
                        pracownicy[i].kontrakt.Pensja();
                    else
                        pracownicy[i].kontrakt.Pensja(15);
                }
                List<Pracownik> posortowana = pracownicy.OrderBy(i => i.kontrakt._pensja).ToList();
                return posortowana;
            }
            else
            {
                List<Pracownik> posortowana = pracownicy.OrderBy(i => i.nazwisko).ToList();
                return posortowana;
            }
    }
        static void Main(string[] args)
        {
            //imiona i nazwiska: https://gist.github.com/ruanbekker/a1506f06aa1df06c5a9501cb393626ea
            string[] imiona = { "Aaran", "Aaren", "Aarez", "Aarman", "Aaron", "Aaron-James", "Aarron", "Aaryan", "Aaryn", "Aayan", "Aazaan", "Abaan", "Abbas", "Abdallah", "Abdalroof", "Abdihakim", "Abdirahman", "Abdisalam", "Abdul", "Abdul-Aziz", "Abdulbasir", "Abdulkadir", "Abdulkarem", "Abdulkhader", "Abdullah", "Abdul-Majeed", "Abdulmalik", "Abdul-Rehman", "Abdur", "Abdurraheem", "Abdur-Rahman", "Abdur-Rehmaan", "Abel", "Abhinav", "Abhisumant", "Abid", "Abir", "Abraham", "Abu", "Abubakar", "Ace", "Adain", "Adam", "Adam-James", "Addison", "Addisson", "Adegbola", "Adegbolahan", "Aden", "Adenn" };
            string[] nazwiska = { "Harley", "Harman", "Harnek", "Harold", "Haroon", "Harper", "Harri", "Harrington", "Harris", "Harrison", "Harry", "Harvey", "Harvie", "Harvinder", "Hasan", "Haseeb", "Hashem", "Hashim", "Hassan", "Hassanali", "Hately", "Havila", "Hayden", "Haydn", "Haydon", "Haydyn", "Hcen", "Hector", "Heddle", "Heidar", "Heini", "Hendri", "Henri", "Henry", "Herbert", "Heyden", "Hiro", "Hirvaansh", "Hishaam" };
            List<Pracownik> pracownicy = new List<Pracownik>();
            Random r = new Random();
            for(int i = 0; i < 20; i++)
            {
                string imie = imiona[r.Next(0, imiona.Length)];
                string nazwisko = nazwiska[r.Next(0, nazwiska.Length)];
                int typK = r.Next(0, 2);
                Kontrakt k;
                if (typK == 1)
                    k = new Kontrakt(2000, Kontrakt._typKontraktu.staz);
                else
                    k = new Kontrakt(r.Next(5000, 6000), Kontrakt._typKontraktu.etat);
                pracownicy.Add(new Pracownik(imie, nazwisko, k));
            }
            for(int i = 0; i < 5; i++)
            {
                pracownicy[r.Next(0, pracownicy.Count)].ZmienKontrakt(new Kontrakt(4321, Kontrakt._typKontraktu.etat));
            }
            for (int i = 0; i < 5; i++)
            {
                pracownicy[r.Next(0, pracownicy.Count)].ZmienPodstawe(6666);
            }

            Console.WriteLine("Wygenerowano liste pracownikow");
            WypiszPracownikow(pracownicy);
            Console.WriteLine("\nSortowanie listy...");
            pracownicy = SortujListe(pracownicy);
            WypiszPracownikow(pracownicy);
            Pracownik kopia1 = pracownicy[r.Next(0, pracownicy.Count)].Clone();
            kopia1.imie = "AAAAAAA";
            kopia1.nazwisko = "BBBBBBB";
            Pracownik kopia2 = pracownicy[r.Next(0, pracownicy.Count)].Clone();
            kopia1.imie = "CCCCCCC";
            kopia1.nazwisko = "DDDDDDD";
            pracownicy.Add(kopia1);
            pracownicy.Add(kopia2);
            Console.WriteLine("\nSortowanie listy po pensji");
            pracownicy = SortujListe(pracownicy, "pensja");
            WypiszPracownikow(pracownicy);



            Console.ReadKey();

        }

    }
}

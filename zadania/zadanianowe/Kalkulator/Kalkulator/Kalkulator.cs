using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Kalkulator
    {
        public double ostatniWynik = 0;

        public Kalkulator()
        {
        }

        public double Dodawanie(params double[] ListNumbers)
        {
            double wynik = 0;
            foreach(var liczba in ListNumbers)
            {
                wynik += liczba;
            }
            ostatniWynik = wynik;
            return wynik;
        }
        public double Odejmowanie(params double[] ListNumbers)
        {
            double wynik = ListNumbers[0];
            for(int i = 1; i < ListNumbers.Length; i++)
            {
                wynik -= ListNumbers[i];
            }
            ostatniWynik = wynik;
            return wynik;
        }
        public double Mnozenie(params double[] ListNumbers)
        {
            double wynik = 1;
            foreach (var liczba in ListNumbers)
            {
                wynik *= liczba;
            }
            ostatniWynik = wynik;
            return wynik;
        }
        public double Dzielenie(params double[] ListNumbers)
        {
            double wynik = ListNumbers[0];
            for(int i = 1; i < ListNumbers.Length; i++)
            {
                wynik /= ListNumbers[i];
            }
            ostatniWynik = wynik;
            return wynik;
        }
    }
}

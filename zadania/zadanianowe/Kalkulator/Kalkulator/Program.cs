using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulator c = new Kalkulator();
            Console.WriteLine(c.Dodawanie(1, 2, 3));
            Console.WriteLine(c.Odejmowanie(1, 2, 3));
            Console.WriteLine(c.Mnozenie(1, 2, 3));
            Console.WriteLine(c.Dzielenie(1, 2, 3));

            Console.ReadKey();
        }
    }
}

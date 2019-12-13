using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08
{
    class Program
    {
        static void metoda23()
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 11;
            c = 12;
            try
            {
                Console.WriteLine(a / 0);
                Console.WriteLine(b / 0);
                Console.WriteLine(c / 0);
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            try
            {
                metoda23();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("MOJ WYJATEK");
                throw new NaszWyjatekException();
            }
            catch(NaszWyjatekException e)
            {
                Console.WriteLine(e.Message);
            }
            
            /*
                StackOverflowException - zbyt wiele wywołań metod zagnieżdżonych
                NullReferenceException - odwołanie do obiektu o wartości null
                FileNotFoundException - próba odczytu pliku który nie istnieje
                AccessViolationException - podjęto próbę odczytu lub zapisu chronione pamięci.
                IndexOutOfRangeException - indeks, który znajduje się poza granicami
             */
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_testowy
{
    class Program
    {
        static void Main(string[] args)
        {
         Character char1 = Character.generate(3, 1,1,"kasztan",charClass.archer);
         Character char2 = Character.generate(1, 2, 2, "leszcz", charClass.mage);
            Console.WriteLine(char1.level);
            Console.WriteLine(char1.klasa);
            char1.action();
            Console.ReadKey();


        }
    }
}

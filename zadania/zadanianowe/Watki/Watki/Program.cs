using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Watki
{
    class Program
    {
        static void Licz()
        {
            for(int i = 0; i < 10000; i++)
                Console.WriteLine($"Watek1: {i}");
        }
        static void Main(string[] args)
        {
            Thread thr = new Thread(Licz);
            thr.Start();
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Program1 {i}");
            }


            Console.ReadKey();
        }
    }
}

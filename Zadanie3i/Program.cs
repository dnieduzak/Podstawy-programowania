using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3i
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj liczbę nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            //szukamy najmniejszej liczby
            if ((a<=b) && (a<=c))
                Console.WriteLine("Najmniejsza liczba to {0}", a);
            else if ((b<=a) && (b<=c))
                    Console.WriteLine("Najmniejsza liczba to {0}", b);
            else
                Console.WriteLine("Najmniejsza liczba to {0}", c);
            Console.ReadKey(true);
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4p
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            Console.WriteLine("Podaj liczbę naturalną: n =  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę naturalną k = ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; 1 <= n; i++) //liczba wierszy
            {
                for (j = 1; j <= k; j++) //liczba kolumn
                    Console.WriteLine("*");
                Console.WriteLine("");//nowa linia


            }
            Console.ReadKey(true);
        }
    }
}

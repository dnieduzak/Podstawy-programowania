using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5p
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Podaj liczbę naturalną n>1: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) // liczba wierszy
            {
                for (j = 1; j <= i; j++) // lliczba kolumn
                    Console.Write("*");
                Console.WriteLine("");//nowa linia

            }
            Console.ReadKey(true);
                }
    }
}

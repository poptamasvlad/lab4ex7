using System;

namespace lab4ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
            afisa urmatoarea piramida a numerelor:
            1
            2 2
            3 3 3
            4 4 4 4
            …
            n n n ….. n*/

            int n = int.Parse(Console.ReadLine());

            Piramida(n);

        }
        static void Piramida(int n)
        {
            if(n > 1)
            {
                Piramida(n - 1);
            }
            for(int i = 1; i <= n; i++)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}

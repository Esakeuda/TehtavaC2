using System;

namespace TehtavaC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä ensimmäinen kokonaisluku: ");
            int luku1 = int.Parse(Console.ReadLine());

            Console.Write("Syötä toinen kokonaisluku: ");
            int luku2 = int.Parse(Console.ReadLine());

            Console.Write("Syötä kolmas kokonaisluku: ");
            int luku3 = int.Parse(Console.ReadLine());

            int suurinLuku = luku1;

            if (luku2 > suurinLuku)
            {
                suurinLuku = luku2;
            }

            if (luku3 > suurinLuku)
            {
                suurinLuku = luku3;
            }

            Console.WriteLine("Suurin luku on: " + suurinLuku);
        }
    }
}

using System;

namespace UnosBrojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz1 = new int[10];
            int[] niz2 = new int[10];
            int brojac1 = 0;
            int brojac2 = 0;

            while (true)
            {
                Console.WriteLine("Unesite broj: ");
                int broj = Convert.ToInt32(Console.ReadLine());

                if (broj == 0 || brojac1 + brojac2 >= 10)
                {
                    break;
                }

                if (broj % 2 == 0)
                {
                    niz2[brojac2] = broj;
                    brojac2++;
                }
                else
                {
                    niz1[brojac1] = broj;
                    brojac1++;
                }
            }

            Console.WriteLine("Prvi niz: ");
            for (int i = 0; i < brojac1; i++)
            {
                Console.WriteLine(niz1[i]);
            }

            Console.WriteLine("Drugi niz: ");
            for (int i = 0; i < brojac2; i++)
            {
                Console.WriteLine(niz2[i]);
            }
        }
    }
}

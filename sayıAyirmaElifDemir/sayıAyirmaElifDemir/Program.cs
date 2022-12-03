using System;

namespace sayıAyirmaElifDemir
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            int rsayi, nBoyut = 0, pBoyut = 0, nsayac = 0, psayac = 0;

            Random r = new Random();

            for (int i = 0; i < 10; i++)

            {

                rsayi = r.Next(-100, 100);

                sayilar[i] = rsayi;

                if (rsayi < 0) nBoyut++;

                else pBoyut++;

            }

            int[] negatif = new int[nBoyut];

            int[] pozitif = new int[pBoyut];

            foreach (int i in sayilar)

            {

                if (i < 0)

                {

                    negatif[nsayac] = i;

                    nsayac++;

                }

                else

                {

                    pozitif[psayac] = i;

                    psayac++;

                }

            }

            Console.WriteLine("\nÜretilen Sayılar");

            foreach (int i in sayilar)

            {

                Console.Write(" {0} ", i);

            }

            Console.WriteLine("\nÜretilen Sayılardan Negatif Olanlar");

            foreach (int i in negatif)

            {

                Console.Write(" {0} ", i);

            }

            Console.WriteLine("\nÜretilen Sayılardan Pozitif Olanlar");

            foreach (int i in pozitif)

            {

                Console.Write(" {0} ", i);

            }

            Console.ReadKey();

        }
    }
}

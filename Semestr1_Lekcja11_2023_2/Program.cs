using System;

namespace Semestr1_Lekcja11_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Powtórzenie pętli FOR

            //1
            //2
            //3
            //4
            //5
            //6
            //7
            //8
            //9
            //10

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Clear();

            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            int y = 1;
            do
            {
                Console.WriteLine("Test");
                y++;
            }
            while (10 >= y);

            Console.Clear();

            // TABLICE

            //100 uczestników

            //wiek uczestników

            //pojedynczy uczestnik
            int uczestnik = 21;

            //tablica uczestników
            int[] uczestnicy = {24, 21, 23, 24, 52, 21, 52, 32, 21, 53, 64, 12, 52, 32, 21, 52, 21, 52, 10, 31, 52};

            int sumaWiekuUczestnikow = 0;

            for (int i = 0; i < uczestnicy.Length; i++)
            {
                Console.WriteLine(uczestnicy[i]);
                sumaWiekuUczestnikow = sumaWiekuUczestnikow + uczestnicy[i];
            }

            double srednia = (double)sumaWiekuUczestnikow / uczestnicy.Length;
            Console.WriteLine($"Średnia wieku uczestników to {Math.Round(srednia,2)} lat");

            Console.Clear();
            //Zadanie 1

            string[] gry = {"Cs: GO", "Fortnite", "Forza Horizon", "Assassins Creed", "Fifa 2023", "NFS Most Wanted"};

            Random random = new Random();
            int losowa = random.Next(0, gry.Length);

            Console.WriteLine("Twoja wylosowana gra na dziś to:");
            Console.WriteLine(gry[losowa]);

            Console.Clear();
            //Zadanie 2 

            int[] tablicaLiczb = {21, 20000, -999, 2, 532, 12, 1, 121, 12, 42 };
            int aktualnieNajwiększa = tablicaLiczb[0];
            int aktualnieNajmniejsza = tablicaLiczb[0];

            for (int i = 0; i < tablicaLiczb.Length; i++)
            {
                if (aktualnieNajwiększa < tablicaLiczb[i])
                {
                    aktualnieNajwiększa = tablicaLiczb[i];
                }
                if (aktualnieNajmniejsza > tablicaLiczb[i])
                {
                    aktualnieNajmniejsza = tablicaLiczb[i];
                }
            }

            Console.WriteLine($"Największa liczba w tablicy to {aktualnieNajwiększa}");
            Console.WriteLine($"Najmniejsza liczba w tablicy to {aktualnieNajmniejsza}");

            // foreach
            int sumaLiczb = 0;
            foreach(int liczba in tablicaLiczb)
            {
                sumaLiczb = sumaLiczb + liczba;
            }

            double sredniaLiczb = (double)sumaLiczb / tablicaLiczb.Length;
            Console.WriteLine($"Średnia liczb wynosi {sredniaLiczb}");


            // {"Cs: GO", "Fortnite", "Forza Horizon", "Assassins Creed", "Fifa 2023", "NFS Most Wanted"};

            for (int i = gry.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(gry[i]);
            }

            Console.ReadLine();
        }
    }
}

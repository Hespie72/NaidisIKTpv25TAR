using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace NadisIKTpv25TAR
{
    internal class Osa3
    {
        private static Random random = new Random();
        public static int[] randomarvud(int min, int max)
        {
            int N = random.Next(min, max + 1);
            int M = random.Next(min, max + 1);

            Console.WriteLine($"Genereeritud arvud: N = {N}, M = {M}");

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            int length = end - start + 1;
            int[] ruudud = new int[length];

            for (int i = 0; i < length; i++)
            {
                int number = start + i;
                ruudud[i] = number * number;
            }

            return ruudud;

        }
        public static (double summa, double keskmine, double korrutis) AnaluusiArvel(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return (summa, keskmine, korrutis);
        }
        public static Tuple<int, double, Inimene, Inimene> Statistika(List<Inimene> inimesed)
        {
            int summa = inimesed.Sum(i => i.Vanus);
            double keskmine = inimesed.Average(i => i.Vanus);
            Inimene vanim = inimesed.OrderByDescending(i => i.Vanus).First();
            Inimene noorim = inimesed.OrderBy(i => i.Vanus).First();
            return Tuple.Create(summa, keskmine, vanim, noorim);
        }
        public static void ostsElevantAra()
        {
            string vastus;
            do
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();

            } while (vastus != "jah");

            while (true)
            {
                Console.WriteLine("Osts elevant ära");
                vastus = Console.ReadLine().ToLower();
                if (vastus == "jah")
                {
                    Console.WriteLine("Oled ostnud elevandi!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kõik nii rakivad, aga Osts elevant ära");
                }

            }



        }
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine(); // Uus rida pärast iga rea täitmist
            }
            return tabel;
        }
        public static void õpilastegaMängime(string[] nimed)
        {
            Console.Write("milleks: ");
            string nimi = Console.ReadLine();
            nimed[2] = nimi;
            nimed[5] = "Mati";
            int i = 0;
                while (i < nimed.Length)
            {
                if (nimed[i].StartsWith("A"))
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
                i++;
            }
            for (int j = 0; j < nimed.Length; j++)
            {
                Console.WriteLine($"Indeks: {j}, Nimi {nimed[j]}");
            }
            foreach (string nimii in nimed)
            {
                Console.WriteLine(nimii.ToLower());
            }
            i = 0;
            do
            {
                if (nimed[i] == "Mati")
                {
                    Console.WriteLine($"Tere, {nimed[i]}!");
                }
            } while (i<nimed.Length);
        }
    }
}

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
        public static void arvumang()
        {

            int arv = random.Next(1, 101);
            int katse = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Arva ära number 1-100: ");
                int arva = int.Parse(Console.ReadLine());
                katse++;
                if (arva > arv)
                {
                    Console.WriteLine("Sinu number on väiksem");
                }
                else if (arva < arv)
                {
                    Console.WriteLine("Sinu number on suurem");
                }
                else
                {
                    Console.WriteLine($"Õige! Arvasid ära {katse} katsel.");
                    break;
                }
            }

        }
        public static void SuurimNeliarv()
        {
            Console.WriteLine("Sisesta neli arvu:");

            double[] arvud = new double[4];
            for (int i = 0; i < arvud.Length; i++)
            {

                Console.Write($"Sisesta {i + 1}. arv: ");
                int arvu = int.Parse(Console.ReadLine());


                foreach (double arv in arvud)
                {
                    string tulemus = string.Join(", ", arvud);
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
        public static void arvudRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"arv: {arvud[i]} ruut: {arvud[i] * arvud[i]}");
            }
            foreach (int arv in arvud)
            {
                Console.WriteLine($"arv: {arv} ruut: {arv * 2}");
            }
            while (true)
            {
                int i = 0;
                int count = 0;

                while (i < arvud.Length)
                {
                    if (arvud[i] % 3 == 0) // 0 kui on õige
                    {
                        count++;
                    }

                    i++;
                }

                Console.WriteLine("Jagab 3: " + count);

            }


        }
        public static void Positiivsed_ja_negatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };

            int posit = 0;
            int negat = 0;
            int nul = 0;
            foreach (int arv in arvud)
            {
                if (arv > 0)
                {
                    posit++;
                }
                else if (arv < 0)
                {
                    negat++;
                }
                else
                {
                    nul++;
                }

            }
            Console.WriteLine($"Positiivsed: {posit}");
            Console.WriteLine($"Negatiivsed: {negat}");
            Console.WriteLine($"Nullid: {nul}");
        }
        public static void rohkemkuiKeskmine()
        {
            int arvu = random.Next(1, 101);
            int[] arvud = new int[15];
            int summa = 0;
            foreach (int arv in arvud)
            {
                summa += arv;
            }
            double keskmine = summa / arvud.Length;
            Console.WriteLine($"Keskmine: {keskmine}");
            Console.WriteLine("Arvud, mis on suuremad kui keskmine:");
            foreach (int arv in arvud)
            {
                if (arv > keskmine)
                {
                    Console.WriteLine(arv);
                }
            }
        }
        public static void suurimJaIndeks()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };

            int max = numbrid[0];
            int index = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > max)
                {
                    max = numbrid[i];
                    index = i;
                }
            }

            Console.WriteLine("surim: " + max);
            Console.WriteLine("indeks: " + index);

        }
        public static void binaariost()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            numbrid = numbrid.OrderBy(n => n).ToArray(); // Sortime massiivi kasvavalt
            int vask = 0;
            int parem = numbrid.Length - 1;
            while (vask <= parem)
            {
                int keskmine = vask + (parem - vask) / 2;
                if (numbrid[keskmine] == 78)
                {
                    Console.WriteLine("Leidsin 78 indeksil: " + keskmine);
                    return;
                }
                else if (numbrid[keskmine] < 78)
                {
                    vask = keskmine + 1;
                }
                else
                {
                    parem = keskmine - 1;
                }
            }
        }
        public static void PaariPaaritud()
        {
            List<int> Arvud = new List<int>();
            int summa = 0;
            int keskmine = 0;
            for (int i = 0; i < 20; i++)
            {
                Arvud.Add(random.Next(1, 21));
            }
            for (int i = 0; i < Arvud.Count; i++)
            {


                if (Arvud[i] % 2 == 0)
                {
                    summa += Arvud[i];
                }
                else
                {
                    keskmine += Arvud[i];

                }
            }
            Console.WriteLine($"Summa: {summa}, keskmine: {keskmine}");
        }
    }
}

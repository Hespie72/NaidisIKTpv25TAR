using System;
using System.Collections.Generic;
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
    }
}


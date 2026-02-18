using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace NadisIKTpv25TAR
{
    internal class NaidisFunktsioonid
    {
        public static float Summa(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "Novemberr"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;
        }
        int[] arvud = new int[5];
        public static void Muuda_element_massiivis(int[] arvud)
        {
            int pos;
            Console.WriteLine("Sisesta mis positsiooni sa tahad muuda: ");
            pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis number sa tahad?: ");
            int uusarv;
            uusarv = int.Parse(Console.ReadLine());
            arvud[pos - 1] = uusarv;
            Console.WriteLine("Uuendatud massiiv");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine(arvud[i]);
            }
        }

        public static int[] Täida_massiiv(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            return arvud;
        }
        public static void Massiivide_kuvamine(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"Sisetatud arv: {arvud[i]}");
            }
            
        }
        public static void foreac(int[] arvud)
        {
            for (int i = arvud.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"Sisetatud arv: {arvud[i]}");
            }

        }
    }
}
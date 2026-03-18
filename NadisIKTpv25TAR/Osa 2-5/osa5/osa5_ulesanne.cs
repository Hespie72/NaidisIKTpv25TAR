using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NadisIKTpv25TAR.Osa_2_4.osa5
{
    internal class osa5_ulesanne
    {

        public class Toode
        {
            public string Nimi { get; set; }
            public int Kalorid100g { get; set; }
        }
        public class inimene
        {
            public string Nimi { get; set; }
            public int Vanus { get; set;  }
            public string Sugu { get; set; }
            public int Pikkus { get; set; }
            public int Kaal { get; set; }
            public string Aktiivsustase { get; set; }
        }

        public static void kalk_kalorii()
        {
            List<Toode> toidud = new List<Toode>()
        {
            new Toode { Nimi = "Õun", Kalorid100g = 52 },
            new Toode { Nimi = "Riis", Kalorid100g = 130 },
            new Toode { Nimi = "Kana", Kalorid100g = 239 }
        };

            inimene inimene = new inimene();

            Console.Write("Nimi: ");
            inimene.Nimi = Console.ReadLine();

            Console.Write("Vanus: ");
            inimene.Vanus = int.Parse(Console.ReadLine());

            Console.Write("Kaal: ");
            inimene.Kaal = int.Parse(Console.ReadLine());

            Console.Write("Pikkus: ");
            inimene.Pikkus = int.Parse(Console.ReadLine());

            Console.Write("Sugu (m/n): ");
            inimene.Sugu = Console.ReadLine();

            double kaalBMR = 0;
            if (inimene.Sugu == "m")
            {
                kaalBMR = 66 + 13 * inimene.Kaal + 5 * inimene.Pikkus - 6 * inimene.Vanus; 
            }
            else
            {
                kaalBMR = 655 + 9 * inimene.Kaal + 3 * inimene.Pikkus - 4 * inimene.Vanus;
            }

        }

    }
}

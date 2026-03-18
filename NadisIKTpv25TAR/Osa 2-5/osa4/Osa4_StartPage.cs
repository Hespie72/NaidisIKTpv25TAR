using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
Console.OutputEncoding = Encoding.UTF8;

namespace NadisIKTpv25TAR
{
    public class Osa4_StartPage
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sisesta 1-5 \n 1.Lemmik toit \n 2.loe fail \n 3.Listi muutmine \n 4.Otsing nimekirjas \n 5.salvesta fail");
                int valik = int.Parse(Console.ReadLine());
                if (valik == 1)
                {
                    Osa4.Lemmiktoit(); break;
                }
                else if (valik == 2)
                {
                    Console.WriteLine("Sisesta nimi faili *text.txt*: ");
                    string file = Console.ReadLine();
                    Osa4.Ridade_Lugamine(file); break;
                }
                else if (valik == 3)
                {
                    Osa4.Listi_muutmine();
                }
            }
            
        }
    }
}
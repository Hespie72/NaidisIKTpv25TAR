using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace NadisIKTpv25TAR
{
    internal class ulesanded
    {
        public static string kinno(string nimi, int vanus)
        {
            try
            {
                if (nimi.ToLower() == "juku" && vanus < 6)
                {
                    Console.WriteLine($"Tere {nimi} lähme kinnos!");
                    Console.WriteLine("Sinu pilet on tasuta!");

                }
                else if (nimi.ToLower() == "juku" && vanus >= 6 && vanus <= 65)
                {
                    Console.WriteLine($"Tere {nimi} lähme kinnos!");
                    Console.WriteLine("Sinu pilet on lastepilet!");
                }
                else if (nimi.ToLower() == "juku" && vanus > 65)
                {
                    Console.WriteLine($"Tere {nimi} lähme kinnos!");
                    Console.WriteLine("Sinu pilet on sooduspilet!");
                }
                else if (nimi.ToLower() == "juku" && vanus <= 0 && vanus >= 100)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch (Exception d)
            {
                Console.WriteLine(d);
            }
            return $"Nagemist {nimi}";

        public static int porandPindal(int pikkus1, int pikkus2)
        {
            int porand = pikkus1 * pikkus2;
            return porand;
        }

        public static int remondihinnearvutamine(int pikkus)
        {
            int hind = pikkus * 15;
            return hind;
        }

        public static string temperatuur(int temp)
        {
            string Message1 = "";
            try
            {
                if (temp > 17)
                {
                    Message1 = "Temperatuur on kõigem kui 18 kraadi";
                }
                else if (temp < 18)
                {
                    Message1 = "Temperatuur on vähem kui 18 kraadi";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return Message1;

        }
    }
}

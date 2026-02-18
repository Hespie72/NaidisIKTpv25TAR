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
        }

        public static int porand(int pikkus1, int pikkus2)
        {
            int porand = pikkus1 * pikkus2;
            return porand;
        }

        public static int remondihinearvutamine(int pik)
        {
            int hind = pik * 15;
            return hind;
        }

        public static string temperaturi(int temp)
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
            public static string inimesedpik(int pikk)
            {
            string message = "";
            try
            {
                if (pikk <= 140)
                {
                    message = "Sa oled lühike";
                }
                else if (pikk > 140 && pikk <= 185)
                {
                    message = "Sa oled keskmine";
                }
                else if (pikk > 185)
                {
                    message = "Sa oled pikk";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return message;
            }
        
            public static string pikkussugu(string sugu)
            {
                string message = "";
                int pikkus = 0;
                Console.WriteLine("Sisesta pikkus: ");
                pikkus = int.Parse(Console.Readline());
                if (sugu = "mees")
                {
                    if (pikk < 140)
                    {
                        message = "Sa oled lühike";
                    }
                    else if (pikk > 140 && pikk <= 185)
                    {
                        message = "Sa oled keskmine";
                    }
                    else if (pikk > 185)
                    {
                        message = "Sa oled pikk";
                    }
                }
                else if (sugu = "naine")
                {
                    if (pikk <= 130)
                    {
                        message = $"Sa oled lühike ja sa oled {sugu}";
                    }
                    else if (pikk > 130 && pikk <= 170)
                    {
                        message = $"Sa oled keskmine ja sa oled {sugu}";
                    }
                    else if (pikk > 170)
                    {
                        message = $"Sa oled pikk ja sa oled {sugu}";
                    }
                }
            return message;

        }
    }
}

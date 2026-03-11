using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Channels;

namespace NadisIKTpv25TAR
{
    internal class Osa2
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
                else if (nimi.ToLower() != "juku")
                {
                    Console.WriteLine($"Tere, {nimi}");
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
        public static string Pinginaabrid()
        {
            Console.WriteLine("Sisesta nimi 1: ");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Sisesta nimi 2");
            string nimi2 = Console.ReadLine();
            string vastus = $"Täna on pinginaabrid {nimi1} ja {nimi1}";
            return vastus;
            
        }
        public static void reemondiKalk()
        {
            Console.WriteLine("Sisesta seine pikkus 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta seine pikkus 2: ");
            int b = int.Parse(Console.ReadLine());
            int S = a * b;
            Console.WriteLine($"{S} on põranda pindala");
            Console.WriteLine("Kas sa soovid reemonti teha? (y/n): ");
            string vastus = Console.ReadLine();
            if (vastus == "y")
            {
                Console.WriteLine("Kui palju ruutmeetri hinda?");
                int hind = int.Parse(Console.ReadLine());
                int vastus2 = S * hind;
                Console.WriteLine(vastus2);
            }
            else if (vastus == "n")
            {
                Console.WriteLine("Nägemist!");
            }
            else 
            {
                Console.WriteLine("Palun sisesta y/n");
            }
        }
        public static void AlgneHind()
        {
            Console.WriteLine("Sisesta soodushind: ");
            double soodusHind = double.Parse(Console.ReadLine());
            double algneHind = soodusHind / 0.7;
            Console.WriteLine("Algne hind oli: " + algneHind);
        }
        public static void Temperatuur()
        {
            Console.Write("Sisesta toatemperatuur: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp >= 18)
            {
                Console.WriteLine("Temperatuur on piisav.");
            }
            else
            {
                Console.WriteLine("Liiga külm!");
            }
        }
        public static void Pikkus()
        {
            Console.WriteLine("Sisesta pikkus cm: ");
            int pikkus = int.Parse(Console.ReadLine());

            if (pikkus < 160)
            {
                Console.WriteLine("Lühike");
            }
            else if (pikkus < 180)
            {
                Console.WriteLine("Keskmine");
            }
            else
            {
                Console.WriteLine("Pikk");
            }
        }
        public static void PikkusjaSugu()
        {
            Console.Write("Sisesta oma sugu (M/N): ");
            string sugu = Console.ReadLine();
            Console.Write("Sisesta oma pikkus cm: ");
            int pikkus = int.Parse(Console.ReadLine());
            if (sugu.ToUpper() == "M")
            {
                if (pikkus < 165)
                {
                    Console.WriteLine("Sa oled lühike mees.");
                }
                else if (pikkus <= 185)
                {
                    Console.WriteLine("Sa oled keskmise pikkusega mees.");
                }
                else
                {
                    Console.WriteLine("Sa oled pikk mees.");
                }
            }
            else if (sugu.ToUpper() == "N")
            {
                if (pikkus < 155)
                {
                    Console.WriteLine("Sa oled lühike naine.");
                }
                else if (pikkus <= 175)
                {
                    Console.WriteLine("Sa oled keskmise pikkusega naine.");
                }
                else
                {
                    Console.WriteLine("Sa oled pikk naine.");
                }
            }
            else
            {
                Console.WriteLine("Vale sugu sisestatud.");
            }
        }
        public static void PoeLeib()
        {
            double piimHind = 1.50;
            double saiHind = 1.20;
            double leibHind = 1.00;
            double summa = 0;

            while (true)
            {
                try
                {
                    Console.Write("Kas soovid osta piima? (jah/ei): ");
                    string piim = Console.ReadLine();
                    if (piim.ToLower() == "jah")
                    {
                        summa += piimHind;
                    }
                    Console.Write("Kas soovid osta saia? (jah/ei): ");
                    string sai = Console.ReadLine();
                    if (sai.ToLower() == "jah")
                    {
                        summa += saiHind;
                    }
                    Console.Write("Kas soovid osta leiba? (jah/ei): ");
                    string leib = Console.ReadLine();
                    if (leib.ToLower() == "jah")
                    {
                        summa += leibHind;
                    }
                    Console.WriteLine("Ostukorvi kogumaksumus on: " + summa + " eurot.");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e); ;
                }
                
            }
            
        }
    }
}

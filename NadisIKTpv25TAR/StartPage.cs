using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace NadisIKTpv25TAR
{
    public class StartPage
    {
        public static void Main(string[] args)
        {







            Console.OutputEncoding = Encoding.UTF8;


            /*
                public static void Main(string[] args)
            {
                double[] arvud = NaidisFunktsioonid.Täida_massiiv(new double[5]);
                var tulemus = Osa3.AnaluusiArvel(arvud);
                Console.WriteLine($"Summa {tulemus.Item1}, Keskmine {tulemus.Item2}, korrutis: {tulemus.Item3}");

                Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
                Console.WriteLine("For:");
                for(int i=0; i<10;i++)
                {
                    Console.WriteLine($"Tere, {i+1}!");
                }
                Console.WriteLine("While:");
                int j = 0;
                while(j<10)
                {
                    Console.WriteLine($"Tere, {j+1}!");
                    j++;
                }
                Console.WriteLine("Do: ");
                do
                {
                    Console.WriteLine($"Tere, {11 - j}!");
                    j--;
                } 
                while (j!=0);
                int[] arvud = new int[5];
                Console.WriteLine("Täisarvude massiiv: ");
                arvud = NaidisFunktsioonid.Täida_massiiv(arvud);
                Console.WriteLine("Foreach abil:");
                foreach (int arv in arvud)
                {
                    Console.WriteLine($"Sisestatud arv: {arv}");
                }
                Console.WriteLine("For abil: eesimine-> viimane");
                NaidisFunktsioonid.Massiivide_kuvamine(arvud);
                Console.WriteLine("For abil: viimane->esimene");
                NaidisFunktsioonid.foreac(arvud);
                //Küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv
                NaidisFunktsioonid.Muuda_element_massiivis(arvud);

                List<Isik> inimesed = new List<Isik>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sisesta nimi: ");
                    string nimi = Console.ReadLine();

                    Console.Write("Sisesta vanus: ");
                    int vanus = int.Parse(Console.ReadLine());

                    Isik uusIsik = new Isik();
                    uusIsik.Nimi = nimi;
                    uusIsik.Vanus = vanus;

                    inimesed.Add(uusIsik);
                }

                Console.WriteLine("\nKõik inimesed tervitavad:\n");

                foreach (Isik isik in inimesed)
                {
                    isik.Tervita();
                }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            string tekst = "123";
            Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            /*Console.WriteLine("Oli loodud muutja tekst, mis võrdub: {0}", tekst);
            Console.Write("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?: ");
            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e); 
            }
            try
            {
                Console.Write("Arv 1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = NaidisFunktsioonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception d)
            {
                Console.WriteLine(d);
            }*/
            /*Random rnd = new Random();
            int juhustlik_arv = rnd.Next(-5,25);
            Console.WriteLine(NaidisFunktsioonid.Kuu_nimetus(juhustlik_arv));
            juhustlik_arv = rnd.Next(-5, 25);
            tekst = NaidisFunktsioonid.Kuu_nimetus(juhustlik_arv);
            Console.WriteLine(tekst);
            Console.WriteLine("Sisesta sõpru nimi: ");
            string sõbrnimi = Console.ReadLine();
            if
            try
            {
                Console.WriteLine("Mis on sinu nimi");
                string nimi = Console.ReadLine();
                Console.WriteLine("Kui vana sa oled?");
                int vanus = int.Parse(Console.ReadLine());
                ulesanded.kinno(nimi, vanus);
            }
            catch (Exception b)
            {
                Console.WriteLine(b);
            }
            */
            int[] arvud = new int[5];
            while (true)
            {
                try
                {
                    Console.WriteLine("2-3 Osa Funktsioonid (2/3)");
                    int valik = int.Parse(Console.ReadLine());
                    if (valik == 2)
                    {
                        Console.WriteLine("Vali 1. Juku kinno \n 2. Pinginaaber \n  3. reemondi kalkulatoor \n 4. Algse hind \n 5. Temperatuur \n 6. Inimene pikkus \n 7. Pikkus ja Sugu \n 8. Poes \n 9. valja");
                        int valik2 = int.Parse(Console.ReadLine());
                        if (valik2 == 1)
                        {
                            Console.WriteLine("Sisesta oma nimi: ");
                            string nimi = Console.ReadLine();
                            Console.WriteLine("Sisesta oma vanus: ");
                            int vanus = int.Parse(Console.ReadLine());
                            Osa2.kinno(nimi, vanus);
                        }
                        else if (valik2 == 2)
                        {
                            Osa2.Pinginaabrid();
                        }
                        else if (valik2 == 3)
                        {
                            Osa2.reemondiKalk();
                        }
                        else if (valik2 == 4)
                        {
                            Osa2.AlgneHind();
                        }
                        else if (valik2 == 5)
                        {
                            Osa2.Temperatuur();
                        }
                        else if (valik2 == 6)
                        {
                            Osa2.Pikkus();
                        }
                        else if (valik2 == 7)
                        {
                            Osa2.PikkusjaSugu();
                        }
                        else if (valik2 == 8)
                        {
                            Osa2.PoeLeib();
                        }
                        else if (valik2 == 9)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Palun sisesta 1-9");
                        }
                    }
                    else if (valik == 3)
                    {
                        Console.WriteLine("sisesta 1-13");
                        int valik3 = int.Parse(Console.ReadLine());
                        if (valik3 == 1)
                        {
                            Console.WriteLine("Sisesta min: ");
                            int min = int.Parse(Console.ReadLine());
                            Console.WriteLine("Sisesta max: ");
                            int max = int.Parse(Console.ReadLine());
                            Osa3.randomarvud(min, max);
                        }
                        else if (valik3 == 2)
                        {
                            double[] arvudMasiiv = NaidisFunktsioonid.Täida_Doublemassiiv(new double[5]);
                            var tulemus = Osa3.AnaluusiArvel(arvudMasiiv);
                            Console.WriteLine($"summa: {tulemus.Item1}, keskmine: {tulemus.Item2}, Korrutis: {tulemus.Item3}");
                        }
                        else if (valik == 3)
                        {
                            Osa3.ostsElevantAra();
                        }
                        else if (valik == 4)
                        {
                            Osa3.arvumang();
                        }
                        else if (valik == 5)
                        {
                            Osa3.SuurimNeliarv();
                        }
                        else if (valik == 6)
                        {
                            Console.WriteLine("Sisesta ridadeArv: ");
                            int ridadeArv = int.Parse(Console.ReadLine()); // 10
                            Console.WriteLine("Sisesta veergudeArv: ");
                            int veergudeArv = int.Parse(Console.ReadLine()); // 10
                            Osa3.GenereeriKorrutustabel(ridadeArv, veergudeArv);
                        }
                        else if (valik == 7)
                        {
                            Osa3.arvudRuudud();
                        }
                        else if (valik == 8)
                        {
                            Osa3.Positiivsed_ja_negatiivsed();
                        }
                        else if (valik == 9)
                        {
                            Osa3.rohkemkuiKeskmine();
                        }
                        else if (valik == 10)
                        {
                            Osa3.suurimJaIndeks();
                        }
                        else if (valik == 11)
                        {
                            Osa3.arvumang();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e); 
                }
                


            }
        }
    }
}

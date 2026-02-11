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
            Console.ForegroundColor = ConsoleColor.Yellow;
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

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //string tekst = "123";
            //Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
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
            if*/
            //try
            //{
            //    Console.WriteLine("Mis on sinu nimi");
            //    string nimi = Console.ReadLine();
            //    Console.WriteLine("Kui vana sa oled?");
            //    int vanus = int.Parse(Console.ReadLine());
            //    ulesanded.kinno(nimi, vanus);
            //}
            //catch (Exception b)
            //{
            //    Console.WriteLine(b);
            //}



        }
    }
}

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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Osa Andmetüübid");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
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
            if*/
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
            
            

        }
    }
}

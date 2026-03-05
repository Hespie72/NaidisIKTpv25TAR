using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace NadisIKTpv25TAR
{
    internal class Osa4
    {
        public static void Lemmiktoit()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = добавить в конец
                Console.WriteLine("Sisesta min 2 itaalia toidu nime: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
                /* 2 Вариант
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Что-то");
                } Файл автоматически закроется здесь
                */
            }
            catch (Exception D)
            {
                Console.WriteLine(D);
            }


        }
        public static List<string> Ridade_Lugamine(string file)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                foreach (string i in kuude_list) Console.WriteLine(i);
            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga");
            }
            return kuude_list;
        }
        public static List<string> Listi_muutmine()
        {
            List<string> kuude_list = new List<string>();
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            Console.WriteLine("Mis kuu sa tahad eemalda?: ");
            string kuud = Console.ReadLine();
            kuude_list.Remove(kuud);

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
            return kuude_list;
        }
        public static void Otsing_nimekirjas()
        {
            List<string> kuude_list = new List<string>();
            kuude_list = Ridade_Lugamine("Kuud.txt");
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");
        }
        public static void listi_salvestamine()
        {
            List<string> kuude_list = new List<string>();
            string path = @"..\..\..\Kuud.txt";
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }

    }
}

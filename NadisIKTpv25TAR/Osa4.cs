using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

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
                // закрыть файл
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Что-то");
                sw.Close(); // Обязательно!
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
        public static void Ridade_Lugamine(string file)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                Console.WriteLine(kuude_list);
            }
            catch (Exception)
            {

                Console.WriteLine("Viga failiga");
            }
        }
    }
}

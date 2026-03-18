using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NadisIKTpv25TAR.Osa_2_4.osa5
{
    internal class osa5
    {
        class Person
        {
            public string Name { get; set; }
        }
        public static void Osa5_Listid()
        {
            List<string> people = new List<string>() { "Kädi", "Marja", "Lisa" };
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            people.Add("Lisa");
            people.Remove("lisa");
            foreach (string p in people)
            {
                Console.WriteLine(p);
            }
            people.RemoveAt(0);
        }
    }
}

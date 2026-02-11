using System;
using System.Collections.Generic;
using System.Text;

namespace NadisIKTpv25TAR
{
    internal class Isik
    {
        public string Nimi;
        public int Vanus;
        public Isik(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public Isik() { }
        public void Tervita()
        {
            Console.WriteLine($"Tere, minu nimi on {Nimi} ja ma olen {Vanus} aastat vana. ");
        }
    }
}

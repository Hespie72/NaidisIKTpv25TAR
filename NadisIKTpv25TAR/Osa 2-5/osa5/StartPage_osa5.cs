using System;
using System.Collections.Generic;
using System.Text;

namespace NadisIKTpv25TAR.Osa_2_4.osa5
{
    internal class StartPage_osa5
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("osa5 funktsioonid");
            string valik = Console.ReadLine();
            switch (valik)
            {
                case "1":
                    osa5.Osa5_Listid();
                    break;
                case "2":
                    osa5_funktsioonid.Tuple();
                    break;
                case "3":
                    Person.List_Klassiga();
                    break;
                case "4":
                    osa5_funktsioonid.Linked_List();
                    break;
                default:
                    Console.WriteLine("Valik puudub");
                    break;

            }
        }
    }
}

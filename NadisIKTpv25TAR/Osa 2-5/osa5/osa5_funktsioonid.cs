using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NadisIKTpv25TAR.Osa_2_4.osa5
{
    internal class osa5_funktsioonid
    {
        public static void array_list()
        {
            ArrayList nimed = new ArrayList();
            {
                nimed.Add("Kati");
                nimed.Add("Mati");
                nimed.Add("Juku");


                if (nimed.Contains("Mati"))
                    Console.WriteLine("Mati olemas");

                Console.WriteLine("Nimesid kokku: " + nimed.Count);

                nimed.Insert(1, "Sass");

                Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
                Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

                nimed.Sort();
                foreach (string nimi in nimed)
                    Console.WriteLine(nimi);
            }
        }



        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }
        public static void Linked_List()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);
            Console.WriteLine("----------------------------------");
            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);
            loetelu.Remove(555);
            LinkedListNode<int> a = loetelu.Find(5);
            loetelu.AddBefore(a, 11);
            loetelu.AddAfter(a, 22);
            Console.WriteLine("----------------------------------");
        }
        public static void Sonatlik()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);
        }

        public static void sonatlik_Klassiga()
        {
            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
        }


    }



    class Person
    {
        public string Name { get; set; }
        // конструктор (чтобы можно было писать new Person("Lisa"))
        public Person(string name)
        {
            Name = name;
        }

        public Person() { }
        // переопределяем сравнение (чтобы Remove работал по Name)
        public override bool Equals(object obj)
        {
            return obj is Person p && p.Name == Name;
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }

        // добавление и вывод
        public static void List_Klassiga()
        {
            List<Person> people = new List<Person>()
        {
            new Person("Kadi"),
            new Person("Mirje")
        };

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        // удаление
        public static void Remove_Listist()
        {
            List<Person> people = new List<Person>()
        {
            new Person("Kadi"),
            new Person("Mirje")
        };

            people.Remove(new Person("Kadi"));

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        // вставка
        public static void Insert_Listisse()
        {
            List<Person> people = new List<Person>()
        {
            new Person("Kadi"),
            new Person("Mirje")
        };

            people.Insert(1, new Person("Juku"));

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        // поиск индекса и удаление
        public static void Otsing_FindIndex()
        {
            List<Person> people = new List<Person>()
        {
            new Person("Kadi"),
            new Person("Mirje")
        };

            int index = people.FindIndex(p => p.Name == "Kadi");
            Console.WriteLine($"Person index: {index}");

            if (index != -1)
                people.RemoveAt(index);

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }

        // удаление объекта
        public static void Remove_Objekt()
        {
            List<Person> people = new List<Person>()
        {
            new Person("Kadi"),
            new Person("Mirje")
        };

            people.Remove(new Person("Lisa")); // если нет, ничего не произойдёт

            foreach (Person p in people)
                Console.WriteLine(p.Name);
        }
    }
}

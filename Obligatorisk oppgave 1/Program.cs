using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_oppgave_1
{
    class Program
    {
        
        public static int Id { get; private set; }

        static void Main(string[] args)
        {
            bool Run = true;

            List<Person> folk = NewMethod();

            Console.WriteLine("hallo skriv disse in commandoen vis du trenger info osen dette fungerer");
            Console.WriteLine("hjelp=>");
            Console.WriteLine("liste=>");
            Console.WriteLine("id=");

            
            while (Run)
            {
                var answer = Console.ReadLine();
                if (answer == "hjelp=>")
                {
                    Console.WriteLine("her skal jeg forklare dette får deg.");
                    Console.WriteLine("vis du går inn på liste =>");
                    Console.WriteLine("vis du skriver id=1 for eskempel så får du info om Sverre Magnus");
                    Console.WriteLine("det er 8 personer du kan finne info om så prøv mellom id=1 til id=8");
                }

                else if (answer == "liste=>")
                {
                    foreach (var p in folk)
                    {
                        p.Print();
                    }
                }
                else if (answer.Contains("id="))
                {
                    var answerId = answer.Substring(3);
                    int x = Int32.Parse(answerId);

                    for (var i = 0; i < folk.ToArray().Length; i++)
                    {
                        if (folk[i].Id.Equals(x))
                        {
                            folk[i].Print();
                            var parent = folk[i];

                            foreach (var p in folk)
                            {
                                if (p.Father == parent || p.Mother == parent) p.Print();
                            }
                        }
                    }

                }
            }
        }
        private static List<Person> NewMethod()
        {
            Person sverreMagnus = new Person(1, "Sverre Magnus", "", 2005);
            Person ingridAlexandra = new Person(2, "Ingrid Alexandra", "", 2004);
            Person haakon = new Person(3, "Haakon Magnus", "", 1973);
            Person metteMarit = new Person(4, "Mette-Marit", "", 1973);
            Person marius = new Person(5, "marius", "Borg Høiby", 2005);
            Person harald = new Person(6, "Harald", "", 1937);
            Person sonja = new Person(7, "Sonja", "no last name given", 2005);
            Person olav = new Person(8, "Olav", "no last name given", 2005);

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            List<Person> folk = new List<Person>(8);
            folk.Add(sverreMagnus);
            folk.Add(ingridAlexandra);
            folk.Add(haakon);
            folk.Add(metteMarit);
            folk.Add(marius);
            folk.Add(harald);
            folk.Add(sonja);
            folk.Add(olav);
            return folk;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_oppgave_1
{
    class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public Person Father;
        public Person Mother; 

        public Person(int _Id, string _firstName, string _lastName, int _birthYear, Person _father = null, Person _mother = null)
        {
            Id = _Id;
            FirstName = _firstName;
            LastName = _lastName;
            BirthYear = _birthYear;
            Father = _father;
            Mother = _mother;

        }
        public void Print()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + FirstName);
            Console.WriteLine("LastName: " + LastName);
            Console.WriteLine("BirthYear: " + BirthYear);
            if (Father != null)
            {
                Console.WriteLine("Far " + Father.FirstName + ", Id " + Father.Id);
            }
            if (Mother != null)
            {
                Console.WriteLine("Mor " + Mother.FirstName + ", Id " + Mother.Id);
            }
            Console.WriteLine();
            
        }
    }
}

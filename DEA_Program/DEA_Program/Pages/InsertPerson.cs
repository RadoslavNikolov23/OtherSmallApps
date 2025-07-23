using DEA_Program.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEA_Program.Pages
{
    public static class InsertPerson
    {

        public static Person InsertPersonInDB()
        {
            Console.Write("Inser Person FirstName: ");
            string firstName = Console.ReadLine();

            Console.Write("Inser Person LastName: ");
            string lastName = Console.ReadLine();

            Console.Write("Inser Person ID: ");
            string personID = Console.ReadLine();

            Console.Write("Inser Person Day of Birt (year/mont/day): ");
            string[] arrayBirth = Console.ReadLine().Split('/');
            DateTime dayOfBirth = new DateTime(int.Parse(arrayBirth[0]), int.Parse(arrayBirth[1]), int.Parse(arrayBirth[2]));

            Console.Write("Inser Person CountyOfNationality: ");
            string countyOfNationality = Console.ReadLine();

            Console.Write("Inser addition information about the Person: ");
            string additionalInformations = Console.ReadLine();


            Person person = null;
            if (String.IsNullOrEmpty(additionalInformations))
            {
                person = new Person(firstName, lastName, personID, dayOfBirth, countyOfNationality);
            }
            else
            {
                person = new Person(firstName, lastName, personID, dayOfBirth, countyOfNationality,additionalInformations);
            }

            InsertInDB(person);
            return person;
        }

        private static void InsertInDB(Person person)
        {
            Console.WriteLine("Person inserted!");
        }
    }
}

namespace DEA_Program.Repository
{
    using DEA_Program.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class PersonsRepo:IEnumerable<Person>
    {
        private List<Person> persons;

        public PersonsRepo()
        {
            persons = new List<Person>();
        }

        public IReadOnlyCollection<Person> Persons { get => persons.AsReadOnly(); }

        public void AddPerson(Person person)
        {
            this.persons.Add(person);
        }

        public bool RemovePerson(Person person)
        {
            Person findPerson = GetPerson(person.PersonalID);

            if (findPerson != null)
            {
                this.persons.Remove(person);
                return true;
            }

            return false;
        }

        public Person GetPerson(string Id)
        {
            Person findPerson = persons.FirstOrDefault(p => p.PersonalID == Id);

            return findPerson;

        }

        public bool PersonExist(string Id)
        {
            return this.persons.Any(p => p.PersonalID == Id);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            foreach(var person in this.persons)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

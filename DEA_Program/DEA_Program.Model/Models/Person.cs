namespace DEA_Program.Models
{
    using System;

    public class Person
    {

        public Person(string firstName, string lastName, string personalID, DateTime dayofBirth, string countyOfNationality)
            : this(firstName, lastName, personalID, dayofBirth, countyOfNationality, string.Empty)
        { }

        public Person(string firstName, string lastName, string personalID, DateTime dayofBirth, string countyOfNationality, string additionInformation)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PersonalID = personalID;
            this.DayofBirth = dayofBirth;
            this.CountyOfNationality = countyOfNationality;
            this.AdditionInformation = additionInformation;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalID { get; set; }
        public DateTime DayofBirth { get; set; }
        public string CountyOfNationality { get; set; }
        public string AdditionInformation { get; set; }


    }
}

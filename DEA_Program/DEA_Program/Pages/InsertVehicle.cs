
namespace DEA_Program.Pages
{
    using DEA_Program.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class InsertVehicle
    {

        public static Vehicle InsertVehicleInDB()
        {
            Console.Write("Inser Vehicle Car Registration Number: ");
            string carRegistrationNumber = Console.ReadLine();

            Console.Write("Inser Vehicle Country Of Nationality: ");
            string countryOfNationality = Console.ReadLine();

            Console.Write("Inser Owener ID: ");
            string personID = Console.ReadLine();

            Console.Write("Inser Vehicle Date of Registration (year/mont/day): ");
            string[] arrayRegistration= Console.ReadLine().Split('/');
            DateTime dayOfRegistration = new DateTime(int.Parse(arrayRegistration[0]), int.Parse(arrayRegistration[1]), int.Parse(arrayRegistration[2]));

            Console.Write("Inser addition information about the Vehicle: ");
            string additionalInformations = Console.ReadLine();

            Vehicle vehicle = null;
            if (String.IsNullOrEmpty(additionalInformations))
            {
                vehicle = new Vehicle(carRegistrationNumber, countryOfNationality, personID, dayOfRegistration);
            }
            else
            {
                vehicle = new Vehicle(carRegistrationNumber, countryOfNationality, personID, dayOfRegistration, additionalInformations);
            }

            InsertInDB(vehicle);
            return vehicle;
        }

        private static void InsertInDB(Vehicle person)
        {
            Console.WriteLine("Vehicle inserted!");
        }
    }
}

namespace DEA_Program.Models
{
    using System;

    public class Vehicle
    {
        public Vehicle(string carRegistrationNumber, string countryOfNationality, string vehicleOwnerID, DateTime dateOfRegistration)
            :this(carRegistrationNumber,countryOfNationality, vehicleOwnerID, dateOfRegistration,string.Empty)
        { }

        public Vehicle(string carRegistrationNumber, string countryOfNationality, string vehicleOwnerID, DateTime dateOfRegistration, string additionalInformationAboutTheVehicle)
        {
            this.CarRegistrationNumber = carRegistrationNumber;
            this.CountryOfNationality = countryOfNationality;
            this.VehicleOwnerID = vehicleOwnerID;
            this.DateOfRegistration = dateOfRegistration;
            this.AdditionalInformationAboutTheVehicle = additionalInformationAboutTheVehicle;
        }

        public string CarRegistrationNumber { get; set; }
        public string CountryOfNationality { get; set; }
        public string VehicleOwnerID { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string AdditionalInformationAboutTheVehicle { get; set; }

    }
}

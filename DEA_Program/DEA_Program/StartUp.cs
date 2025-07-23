using DEA_Program.Models;
using DEA_Program.Pages;
using DEA_Program.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEA_Program
{
    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Welcome pick one of the following options: ");

            bool isOn = true;
            PersonsRepo personsRepo = new PersonsRepo(); 
            VehiclesRepo vechiclesRepo = new VehiclesRepo(); 

            while (isOn)
            {
                Console.WriteLine("Login - 1");
                Console.WriteLine("Register Person - 2");
                Console.WriteLine("Register Vechile - 3");
                Console.WriteLine("Print register people - 4");
                Console.WriteLine("Print register vechiles - 5");
                Console.WriteLine("Exit - 6");

                string input=Console.ReadLine();
                Console.WriteLine("---------------------");


                if(int.TryParse(input, out int number))
                {
                    switch (number)
                    {
                        case 1:
                            Console.Write("Inser User Name: ");
                            string userName = Console.ReadLine();

                            Console.WriteLine("Inser Password: ");
                            string password = Console.ReadLine();
                            Login.IsLoginIn(userName,password);
                            break;

                        case 2:
                            personsRepo.AddPerson(InsertPerson.InsertPersonInDB());
                            break;

                        case 3:
                            vechiclesRepo.AddVehicle(InsertVehicle.InsertVehicleInDB());
                            break;

                        case 4:
                            foreach(var person in personsRepo)
                            {
                                Console.WriteLine($"{person.FirstName} {person.LastName} - {person.PersonalID} / {person.DayofBirth}");
                            }
                            break;

                        case 5:
                            foreach (var vehicle in vechiclesRepo)
                            {
                                Person vechileOwner = personsRepo.GetPerson(vehicle.VehicleOwnerID);
                                Console.WriteLine($"{vehicle.CarRegistrationNumber} {vehicle.CountryOfNationality} - {vehicle.DateOfRegistration} / {vechileOwner.FirstName} {vechileOwner.LastName} - {vechileOwner.PersonalID} ");
                            }
                            break;

                        case 6:
                            isOn = false;
                            break;
                        
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

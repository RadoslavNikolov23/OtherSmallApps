namespace DEA_Program.Repository
{
    using DEA_Program.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class VehiclesRepo : IEnumerable<Vehicle>
    {
        private List<Vehicle> vehicles;

        public VehiclesRepo()
        {
            vehicles = new List<Vehicle>();
        }

        public IReadOnlyCollection<Vehicle> Vehicles { get => vehicles.AsReadOnly(); }

        public void AddVehicle(Vehicle person)
        {
            this.vehicles.Add(person);
        }

        public bool RemoveVehicle (Vehicle vehicle)
        {
            Vehicle findPerson = GetVehicle(vehicle.CarRegistrationNumber);

            if (findPerson != null)
            {
                this.vehicles.Remove(vehicle);
                return true;
            }

            return false;
        }

        public Vehicle GetVehicle(string carRegistrationNumber)
        {
            Vehicle findVechile = vehicles.FirstOrDefault(v => v.CarRegistrationNumber == carRegistrationNumber);

            return findVechile;

        }

        public bool VehicleExist(string carRegistrationNumber)
        {
            return this.vehicles.Any(v=>v.CarRegistrationNumber== carRegistrationNumber);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach (var vehicle in this.vehicles)
            {
                yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

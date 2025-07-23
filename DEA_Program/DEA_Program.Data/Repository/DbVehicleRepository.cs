namespace DEA_Program.Data.Repository
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DbVehicleRepository
    {
        private DEADatabaseContext context;

        public DbVehicleRepository(DEADatabaseContext context)
        {
            this.context = context;
        }

        public async Task<int> AddVehicle(DbVehicle vehicle)
        {

            try
            {
                int numberRowsAffected = 0;

                if (!await context.DbVehicles.AnyAsync(v => v.RegistrationNumber == vehicle.RegistrationNumber))
                {
                    await context.DbVehicles.AddAsync(vehicle);
                    numberRowsAffected = context.SaveChanges();
                }
                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the AddVehicle/DbVehicleRepository.cs");
                throw;
            }
        }


        public async Task<DbVehicle> GetVehicleByRegistrationNumber(string registrationNumber)
        {
            try
            {
                return await context.DbVehicles
                                            .Include(v => v.Person)
                                            .ThenInclude(p => p.CustomControls)
                                            .FirstOrDefaultAsync(v => v.RegistrationNumber == registrationNumber);

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the getVehicleByRegistrationNumber/DbVehicleRepository.cs");
                throw;
            }
        }

        public async Task<IList<DbVehicle>> GetAllVechileRecords()
        {
            try
            {
                return await context.DbVehicles
                                                .Include(v=>v.Person)
                                                .ThenInclude(p=>p.CustomControls)
                                                .ToListAsync();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetAllVehicleRecords/DbVehicleRepository.cs");
                throw;
            }
        }

        public async Task<bool> VehicleExist(string registrationNumber)
        {
            try
            {
                return await this.context.DbVehicles
                                                .AnyAsync(v => v.RegistrationNumber == registrationNumber);
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the VehicleExist/DbVehicleRepository.cs");
                throw;
            }
        }

        public async Task<int> UpdateVehicle(DbVehicle vehicle)
        {
            try
            {
                int numberRowsAffected = 0;

                if (vehicle != null && await this.context.DbVehicles.AnyAsync(v=>v.RegistrationNumber==vehicle.RegistrationNumber))
                {
                    context.DbVehicles.Update(vehicle);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdateVehicle/DbVehicleRepository.cs");
                throw;
            }
        }

        public async Task<int> UpdateVehicleOwner(string registrationNumber, string personalID)
        {
            try
            {
                int numberRowsAffected = 0;

                DbVehicle vehicle = await context.DbVehicles.FirstOrDefaultAsync(v => v.RegistrationNumber == registrationNumber);
                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personalID);

                if (vehicle != null || person != null)
                {
                    vehicle.Person = person;
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdateVehicleOwen/DbVehicleRepository.cs");
                throw;
            }
        }

        public async Task<int> DeleteVehicle(string registrationNumber)
        {
            try
            {
                int numberRowsAffected = 0;

                DbVehicle vehicle = await context .DbVehicles.FirstOrDefaultAsync(v => v.RegistrationNumber == registrationNumber);

                if (vehicle != null)
                {
                    context.DbVehicles.Remove(vehicle);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the DeleteVehicle/DbVehicleRepository.cs");
                throw;
            }
        }
    }
}

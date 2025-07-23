namespace DEA_Program.Data.Repository
{
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using System.Threading.Tasks;
    using DEA_Program.Common.Helper;

    public class DbPersonRepository
    {
        private DEADatabaseContext context;

        public DbPersonRepository(DEADatabaseContext context)
        {
            this.context = context;
        }

        public async Task<int> AddPerson(DbPerson person)
        {
            try
            {
                int numberRowsAffected = 0;

                if (!await context.DbPersons.AnyAsync(p => p.PersonalId == person.PersonalId))
                {
                    context.DbPersons.Add(person);

                    numberRowsAffected = context.SaveChanges();
                }
                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the AddPerson/DbPersonRepository.cs");
                throw;
            }
        }

        public async Task<int> AddVehicleToPerson(string registrationNumber, string personalId)
        {
            try
            {
                int numberRowsAffected = 0;

                DbVehicle vehicle = await context.DbVehicles.FirstOrDefaultAsync(v => v.RegistrationNumber == registrationNumber);
                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personalId);

                if (vehicle != null || person != null)
                {
                    person.Vehicles.Add(vehicle);
                    numberRowsAffected = context.SaveChanges();
                }
                return numberRowsAffected;

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the AddVehicleToPerson/DbPersonRepository.cs");
                throw;
            }

        }


        public async Task<DbPerson> GetPersonByPersonalId(string personalId)
        {
            try
            {
                DbPerson person = await context.DbPersons
                                            .Include(p => p.Vehicles)
                                            .ThenInclude(v => v.CustomControls)
                                            .FirstOrDefaultAsync(p => p.PersonalId == personalId);

                return person;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetPersonByPersonalId/DbPersonRepository.cs");
                throw;
            }
        }

        public async Task<IList<DbPerson>> GetAllPersonIdAndNameRecords()
        {
            try
            {
                return await context.DbPersons
                                              .Include(p=>p.Vehicles)
                                              .ThenInclude(v => v.CustomControls)
                                              .ToListAsync();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetAllPersonIdAndNameRecords/DbPersonRepository.cs");
                throw;
            }
        }


        public async Task<bool> PersonExist(string personalId)
        {
            try
            {
                return await this.context.DbPersons
                                                .AnyAsync(p => p.PersonalId == personalId);
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the personExist/DbPersonRepository.cs");
                throw;
            }
        }

        public async Task<int> UpdatePerson(DbPerson person)
        {
            try
            {
                int numberRowsAffected = 0;

                if (person != null && await this.context.DbPersons.AnyAsync(p=>p.PersonalId==person.PersonalId))
                {
                    context.DbPersons.Update(person);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdatePerson/DbPersonRepository.cs");
                throw;
            }
        }

        public async Task<int> UpdatePersonNationality(string personId, CountryCode countryCode)
        {
            try
            {
                int numberRowsAffected = 0;

                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personId);

                if (person != null)
                {
                    person.CountryCode = countryCode;

                    context.DbPersons.Update(person);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdatePersonnatioNality/DbPersonRepository.cs");
                throw;
            }
        }

        public async Task<int> UpdatePersonAdditionIntormation(string personId, string additionInformation)
        {
            try
            {
                int numberRowsAffected = 0;

                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personId);

                if (person != null)
                {
                    person.AdditionInformation = additionInformation;

                    context.DbPersons.Update(person);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdatePersonAdditionInormation/DbPersonRepository.cs");
                throw;
            }
        }


        public async Task<int> UpdatePersonVehicles(string personId, string registrationNumber)
        {
            try
            {
                int numberRowsAffected = 0;

                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personId);
                DbVehicle vehicle = await context.DbVehicles.FirstOrDefaultAsync(v => v.RegistrationNumber == registrationNumber);

                if (vehicle != null && person != null)
                {
                    person.Vehicles.Add(vehicle);

                    context.DbPersons.Update(person);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UpdatepersonVehicles/DbPersonRepository.cs");
                throw;
            }
        }


        public async Task<int> DeletePersonVehicle(string personId, string carRegistrationNumber)
        {
            try
            {
                int numberRowsAffected = 0;

                DbPerson person = await context.DbPersons.FirstOrDefaultAsync(p => p.PersonalId == personId);
                DbVehicle vehicle = await context.DbVehicles.FirstOrDefaultAsync(v => v.RegistrationNumber == carRegistrationNumber);

                if (vehicle != null)
                {

                    person.Vehicles.Remove(vehicle);

                    context.DbPersons.Update(person);
                    numberRowsAffected = context.SaveChanges();
                }

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the DeletePersonVehicle/DbPersonRepository.cs");
                throw;
            }
        }
    }
}

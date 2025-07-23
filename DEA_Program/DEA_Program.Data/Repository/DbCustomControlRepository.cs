namespace DEA_Program.Data.Repository
{
    using DEA_Program.Common.Helper;
    using DEA_Program.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DbCustomControlRepository
    {
        private DEADatabaseContext context;

        public DbCustomControlRepository(DEADatabaseContext context)
        {
            this.context = context;
        }

        public async Task<int> AddNewControl(DbCustomControl customContol)
        {
            int numberRowsAffected = 0;

            try
            {
                if (!await context.DbCustomControls.AnyAsync(cc => cc.DayOfVerification == customContol.DayOfVerification))
                {
                    context.DbCustomControls.Add(customContol);
                    numberRowsAffected = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the AddNewControl/DbCutsomControlRepository.cs");
                throw;
            }

            return numberRowsAffected;
        }

        public async Task<IList<DbCustomControl>> GetAllCustomControlWithSpecificDate(DateTime dayOfVerification)
        {
            try
            {
                var allCustomControls = await context.DbCustomControls
                                                    .Include(cc=>cc.Person)
                                                    .ThenInclude(p=>p.Vehicles)
                                                    .Where(cc => cc.DayOfVerification.Year == dayOfVerification.Year
                                                           && cc.DayOfVerification.Month == dayOfVerification.Month
                                                           && cc.DayOfVerification.Day == dayOfVerification.Day)
                                                    .ToListAsync();
                return allCustomControls;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetAllCustomControlWithSpecificDate/DbCustomControlRepository.cs");
                throw;
            }
        }

        public async Task<IList<DbCustomControl>> GetAllCustomControl()
        {
            try
            {
                var allCustomControls = await context.DbCustomControls
                                                                    .Include(cc => cc.Person)
                                                                    .ThenInclude(p => p.Vehicles)
                                                                    .ToListAsync();
                return allCustomControls;

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetAllCustomsControl/DbCustomControlRepository.cs");
                throw;
            }
        }

        public async Task<DbCustomControl> GetCustomControl(DateTime dayOfVerification)
        {
            try
            {
                DbCustomControl customControl = await context.DbCustomControls
                                                                     .Include(cc => cc.Person)
                                                                     .ThenInclude(p => p.Vehicles)
                                                                     .FirstOrDefaultAsync(cc => cc.DayOfVerification == dayOfVerification);
                return customControl;

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetCustomControl/DbCustomControlRepository.cs");
                throw;
            }
        }

        public async Task<bool> CustomControlExist(DateTime dayOfVerification)
        {
            try
            {
                return await this.context.DbCustomControls
                                                .AnyAsync(cc => cc.DayOfVerification == dayOfVerification);
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the CustomControlExist/DbCustomControlRepository.cs");
                throw;
            }
        }

        public async Task<int> DeleteControl(DbCustomControl customContol)
        {
            int numberRowsAffected = 0;
            try
            {
                if (await CustomControlExist(customContol.DayOfVerification))
                {
                    this.context.DbCustomControls.Remove(customContol);
                    numberRowsAffected = context.SaveChanges();
                    return numberRowsAffected;
                }

            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the DeleteControl/DbCustomControlRepository.cs");
                throw;
            }

            return numberRowsAffected;
        }
    }
}

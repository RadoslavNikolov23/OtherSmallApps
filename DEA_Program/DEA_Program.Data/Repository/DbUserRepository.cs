namespace DEA_Program.Data.Repository
{
    using DEA_Program.Data.Model;
    using DEA_Program.Common.Enums;
    using System.Linq;
    using System.Threading.Tasks;
    using DEA_Program.Common.Helper;
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class DbUserRepository
    {
        private DEADatabaseContext context;

        public DbUserRepository(DEADatabaseContext context)
        {
            this.context = context;
        }

        public async Task<int> AddUser(DbUser user)
        {
            int numberRowsAffected = 0;
            try
            {
                if (!context.DbUsers.Any(u => u.Username == user.Username))
                {
                    await context.DbUsers.AddAsync(user);
                    numberRowsAffected = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the AddUser/DbUserRepository.cs");
                throw;
            }

            return numberRowsAffected;
        }

        public async Task<bool> ChangeUserRole(string userName, Role newRole)
        {
            try
            {
                DbUser user = await context.DbUsers.FirstOrDefaultAsync(u => u.Username == userName);
                if (user != null)
                {
                    user.Role = newRole;
                     context.DbUsers.Update(user);
                    context.SaveChanges();
                    return true;

                }

                return false;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the ChangeUserRole/DbUserRepository.cs");
                throw;
            }
        }

        public async Task<DbUser> GetUser(string userName)
        {
            try
            {
                DbUser user = await context.DbUsers.FirstOrDefaultAsync(u => u.Username == userName);

                return user;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetUser/DbUserRepository.cs");
                throw;
            }
        }

        public async Task<IList<DbUser>> GetAllUser()
        {
            try
            {
                return await this.context.DbUsers
                                                .ToListAsync();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the GetAllUser/DbUserRepository.cs");
                throw;
            }
        }

        public async Task<bool> UserExist(string userName)
        {
            try
            {
                return await this.context.DbUsers
                                                .AnyAsync(u => u.Username == userName);
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the UserExist/DbUserRepository.cs");
                throw;
            }
        }

        public async Task<int> DeleteUser(string userName)
        {
            int numberRowsAffected = 0;
            try
            {
                DbUser user = await context.DbUsers.FirstOrDefaultAsync(u => u.Username == userName);

                if (user == null)
                {
                    return numberRowsAffected;
                }

                this.context.DbUsers.Remove(user);
                numberRowsAffected = context.SaveChanges();

                return numberRowsAffected;
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Error in the DeleteUser/DbUserRepository.cs");
                throw;
            }
        }

    }
}

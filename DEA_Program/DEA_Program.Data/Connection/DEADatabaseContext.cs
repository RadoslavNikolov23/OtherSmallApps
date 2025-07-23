namespace DEA_Program.Data
{
    using DEA_Program.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public class DEADatabaseContext : DbContext
    {
        public DEADatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DEADatabaseContext()
        {

        }

        public virtual DbSet<DbUser> DbUsers { get; set; }

        public virtual DbSet<DbPerson> DbPersons { get; set; }

        public virtual DbSet<DbVehicle> DbVehicles { get; set; }

        public virtual DbSet<DbCustomControl> DbCustomControls { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConnectionConfiguration.ConnectionPath);
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DbUser>(entity =>
            {
                entity
                    .HasData(
                        new DbUser { Id = 1, Username = "admin", Password = "admin", Role = 0 }
                        );
            });

            modelBuilder.Entity<DbCustomControl>(entity =>
            {
                entity
                    .Property(cc => cc.PersonId)
                    .IsRequired(false);

                entity
                    .Property(cc => cc.VehicleId)
                    .IsRequired(false);
            });
        }
    }
}

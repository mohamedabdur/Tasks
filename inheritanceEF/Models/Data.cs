using Microsoft.EntityFrameworkCore;

namespace inheritanceEF.Models
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Bike> Bike { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().UseTpcMappingStrategy();

            base.OnModelCreating(modelBuilder);
        }
    }
}
using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Data
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyStorageAppDb");
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Casgem.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-13123BI;initial catalog=CasgemCQRSDB;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
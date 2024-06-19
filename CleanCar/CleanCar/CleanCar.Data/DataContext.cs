using CleanCar.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanCar.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cars> cars { get; set; }
        public DbSet<Agents> agents { get; set; }
        public DbSet<Meeting> meetings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=my_db");
        }

    
    }
}

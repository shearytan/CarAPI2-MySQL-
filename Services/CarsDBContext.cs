using Microsoft.EntityFrameworkCore;
using CarAPI.Entities;

namespace CarAPI.Services
{
    public class CarsDBContext : DbContext
    {
        public DbSet<Car> Cars {get; set;}

        public CarsDBContext (
        DbContextOptions<CarsDBContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
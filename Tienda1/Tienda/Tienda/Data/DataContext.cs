using Microsoft.EntityFrameworkCore;
using Tienda.Data.Entities;

namespace Tienda.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Country> Countries { get; set; }
    }
}

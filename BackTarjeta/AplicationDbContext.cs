using BackTarjeta.Models;
using Microsoft.EntityFrameworkCore;

namespace BackTarjeta
{
    public class AplicationDbContext: DbContext 
    {
        public DbSet<TarjetaCredito> tarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
      
    }
}

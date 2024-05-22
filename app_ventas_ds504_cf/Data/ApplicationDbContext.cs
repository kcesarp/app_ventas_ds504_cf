using Microsoft.EntityFrameworkCore;
using ProyectoDS504_cf.Models;
using web_ventas_ds504_cf.Models;

namespace web_ventas_ds504_cf.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Personal> Personal { get; set; }

        public DbSet<Marca> Marca { get; set; }
    }

}

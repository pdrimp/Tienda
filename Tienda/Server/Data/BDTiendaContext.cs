using Microsoft.EntityFrameworkCore;
using Tienda.Shared.Modelos;

namespace Tienda.Server.Data
{
    public class BDTiendaContext : DbContext
    {
        public BDTiendaContext(DbContextOptions<BDTiendaContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}

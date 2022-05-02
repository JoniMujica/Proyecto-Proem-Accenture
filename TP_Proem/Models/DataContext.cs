using Microsoft.EntityFrameworkCore;

namespace TP_Proem.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
    }


}

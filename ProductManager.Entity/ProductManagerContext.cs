using System.Data.Entity;

namespace ProductManager.Entity
{
    public class ProductManagerContext : DbContext {
        public DbSet<User> Users { get; set; }

        public DbSet<Electric> Electrics { get; set; }

        public ProductManagerContext() : base("ProductManagerDB") {
        }
    }
}
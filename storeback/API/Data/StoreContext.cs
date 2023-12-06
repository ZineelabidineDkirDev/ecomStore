
using Microsoft.EntityFrameworkCore;
using storeback.API.Entities;
namespace API
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> dbContext) : base(dbContext)
        {}

        public DbSet<Product> Products {get; set;}
    }
}
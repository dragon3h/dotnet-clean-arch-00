using CleanApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanApp.Persistence
{
    public class CleanAppDbContext : DbContext
    {
        public CleanAppDbContext(DbContextOptions<CleanAppDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BuyOrder> BuyOrders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Mascot> Mascots { get; set; }
        public DbSet<RentOrder> RentOrders{ get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using RbPrinters.Api.Contracts.Models.Entity;
using RbPrinters.Api.DAL.Configurations;

namespace RbPrinters.Api.DAL
{
    public class RbPrintersDbContext : DbContext
    {
        public RbPrintersDbContext(DbContextOptions<RbPrintersDbContext> options) : base(options){ }
        
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WeddingCard> WeddingCards { get; set; }
        public DbSet<WeddingCardOrder> WeddingCardOrders { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new BranchConfiguration(modelBuilder.Entity<Branch>());
            new CustomerConfiguration(modelBuilder.Entity<Customer>());
            new OrderConfiguration(modelBuilder.Entity<Order>());
            new OrderStatusConfiguration(modelBuilder.Entity<OrderStatus>());
            new PermissionConfiguration(modelBuilder.Entity<Permission>());
            new SupplierConfiguration(modelBuilder.Entity<Supplier>());
            new UserConfiguration(modelBuilder.Entity<User>());
            new UserRoleConfiguration(modelBuilder.Entity<UserRole>());
            new WeddingCardConfiguration(modelBuilder.Entity<WeddingCard>());
            new WeddingCardOrderConfiguration(modelBuilder.Entity<WeddingCardOrder>());
        }
    }
}

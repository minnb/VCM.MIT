using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VCM.MIT.Authorization.Roles;
using VCM.MIT.Authorization.Users;
using VCM.MIT.MultiTenancy;
using VCM.MIT.Entities;

namespace VCM.MIT.EntityFrameworkCore
{
    public class MITDbContext : AbpZeroDbContext<Tenant, Role, User, MITDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Item> Items { get; set; }
        public DbSet<TransHeader> TransHeader { get; set; }
        public DbSet<TransLine> TransLine { get; set; }
        public DbSet<TransPaymentEntry> TransPaymentEntry { get; set; }

        public MITDbContext(DbContextOptions<MITDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasKey(c => new { c.ItemNo });
            modelBuilder.Entity<TransPaymentEntry>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransLine>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransHeader>().HasKey(c => new { c.OrderNo });

            base.OnModelCreating(modelBuilder);
        }
    }
}

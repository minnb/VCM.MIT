using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using VCM.MIT.Authorization.Roles;
using VCM.MIT.Authorization.Users;
using VCM.MIT.MultiTenancy;
using VCM.MIT.Entities;
using VCM.MIT.Entities.Store;
using VCM.MIT.Entities.Tender;
using VCM.MIT.Entities.Trans;
using VCM.MIT.Data.Entities;

namespace VCM.MIT.EntityFrameworkCore
{
    public class MITDbContext : AbpZeroDbContext<Tenant, Role, User, MITDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemUOM> ItemUOM { get; set; }
        public DbSet<ItemGroup> ItemGroup { get; set; }
        public DbSet<TaxGroup> TaxGroup { get; set; }
        public DbSet<TransHeader> TransHeader { get; set; }
        public DbSet<TransLine> TransLine { get; set; }
        public DbSet<TransPaymentEntry> TransPaymentEntry { get; set; }
        public DbSet<TransInfoCodeEntry> TransInfoCodeEntry { get; set; }
        public DbSet<TransDiscountEntry> TransDiscountEntry { get; set; }
        public DbSet<TransRaw> TransRaw { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<WareHouse> WareHouse { get; set; }
        public DbSet<TenderType> TenderType { get; set; }
        public DbSet<TenderTypeSetup> TenderTypeSetup { get; set; }
        public DbSet<EndOfDay> EndOfDay { get; set; }
        public DbSet<EndOfUser> EndOfUser { get; set; }
        public DbSet<CashDeposit> CashDeposit { get; set; }
        public MITDbContext(DbContextOptions<MITDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Item>().HasKey(c => new {c.AppCode, c.ItemNo });
            modelBuilder.Entity<ItemUOM>().HasKey(c => new { c.ItemNo, c.BaseUOM });
            modelBuilder.Entity<ItemGroup>().HasKey(c => new { c.AppCode, c.GroupCode });
            modelBuilder.Entity<TaxGroup>().HasKey(c => new { c.AppCode, c.TaxCode });
            modelBuilder.Entity<TransPaymentEntry>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransLine>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransHeader>().HasKey(c => new { c.OrderNo });
            modelBuilder.Entity<TransInfoCodeEntry>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransDiscountEntry>().HasKey(c => new { c.OrderNo, c.LineNo_ });
            modelBuilder.Entity<TransRaw>().HasKey(c => new { c.TranNo, c.StoreNo, c.CompanyCode, c.AppCode });
            modelBuilder.Entity<TenderType>().HasKey(c => new { c.Code, c.StoreNo });
            modelBuilder.Entity<TenderTypeSetup>().HasKey(c => new { c.Code });
            modelBuilder.Entity<EndOfDay>().HasKey(c => new { c.StoreNo, c.AppCode, c.EntryDate });
            modelBuilder.Entity<EndOfUser>().HasKey(c => new { c.AppCode, c.StoreNo, c.StaffID, c.ShiftNo });
            modelBuilder.Entity<CashDeposit>().HasKey(c => new { c.AppCode, c.StoreNo, c.PosCashId, c.LineNo });
            modelBuilder.Entity<Store>().HasKey(c => new { c.StoreNo });
            modelBuilder.Entity<WareHouse>().HasKey(c => new { c.AppCode, c.WareHouseCode });

            base.OnModelCreating(modelBuilder);
        }
    }
}

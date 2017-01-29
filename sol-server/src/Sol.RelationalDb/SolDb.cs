using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Sol.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sol.RelationalDb.Extensions;

namespace Sol.RelationalDb
{
    public class SolDb: DbContext
    {
        public SolDb(DbContextOptions<SolDb> options) : base(options)
        {
           
        }

        public virtual DbSet<Invoice> Invoice { get; set; }

        public virtual DbSet<Market> Market { get; set; }

        public virtual DbSet<Zone> Zone { get; set; }

        public virtual DbSet<DeliveryPoint> DeliveryPoint { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder.Entity<Invoice>());
            OnModelCreating(modelBuilder.Entity<Market>());
            OnModelCreating(modelBuilder.Entity<Zone>());
            OnModelCreating(modelBuilder.Entity<DeliveryPoint>());
            base.OnModelCreating(modelBuilder);
        }

        protected void OnModelCreating(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice")
                .AsInt32Entity();
        }

        protected void OnModelCreating(EntityTypeBuilder<Market> builder)
        {
            builder.ToTable("Market")
                .AsInt32Entity();
            builder.HasMany(p => p.Zones).WithOne(p => p.Market).HasForeignKey(p => p.MarketId).HasPrincipalKey(p => p.Id).IsRequired();
        }

        protected void OnModelCreating(EntityTypeBuilder<Zone> builder)
        {
            builder.ToTable("Zone")
                .AsInt32Entity();

            // rels
            builder.HasMany(p => p.Invoices).WithOne(p => p.Zone).HasForeignKey(p => p.ZoneId).HasPrincipalKey(p => p.Id);
        }

        protected void OnModelCreating(EntityTypeBuilder<DeliveryPoint> builder)
        {
            builder.ToTable("DeliveryPoint")
                .AsInt32Entity();

            builder.HasMany(p => p.Invoices).WithOne(p => p.DeliveryPoint).HasForeignKey(p => p.DeliveryPointId).HasPrincipalKey(p => p.Id);
        }

        public IDbConnection GetConnection()
        {
            IDbDapperContextFactory f;
            IDbConnection conn = new SqlConnection();
            conn.QueryAsync<Invoice>("select * from dbo.Invoice")
        }
    }
}

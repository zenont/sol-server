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

        public virtual DbSet<Evaluation> Evaluation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreating(modelBuilder.Entity<Invoice>());
            OnModelCreating(modelBuilder.Entity<Market>());
            OnModelCreating(modelBuilder.Entity<Zone>());
            OnModelCreating(modelBuilder.Entity<Evaluation>());
            base.OnModelCreating(modelBuilder);
        }

        protected void OnModelCreating(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice")
                .AsInt32Entity();

            // rels
            builder.HasMany(p => p.Evaluations).WithOne(p => p.Invoice).HasForeignKey(p => p.InvoiceId).HasPrincipalKey(p => p.Id);
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
        }

        protected void OnModelCreating(EntityTypeBuilder<Evaluation> builder)
        {
            builder.ToTable("Evaluation")
                .AsInt32Entity();
        }
    }
}

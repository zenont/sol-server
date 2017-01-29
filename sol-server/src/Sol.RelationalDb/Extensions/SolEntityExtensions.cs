using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sol.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sol.RelationalDb.Extensions
{
    public static class SolEntityExtensions
    {
        public static EntityTypeBuilder<T> AsInt32Entity<T>(this EntityTypeBuilder<T> builder) where T: Int32EntityBase
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.RowVersion)
            .ValueGeneratedOnAddOrUpdate()
            .IsConcurrencyToken();
            return builder;
        }

        public static async Task<bool> DeleteByIdAsync<TEntity>(this DbContext dbContext, int id, CancellationToken cancellationToken = default(CancellationToken))
            where TEntity : class, IEntity<int>
        {
            TEntity entity = await dbContext.FindAsync<TEntity>(id, cancellationToken);
            if (entity == null)
            {
                return false;
            }

            dbContext.Remove(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }

        public static EntityEntry<TEntity> AddOrUpdate<TEntity>(this DbContext dbContext, TEntity entity,
            CancellationToken cancellationToken = default(CancellationToken))
            where TEntity : class, IDatedEntity<int>
        {
            if (entity.Id == 0)
            {
                entity.CreatedUtc = DateTime.UtcNow;
                return dbContext.Add(entity);
            }
            else
            {
                entity.ModifiedUtc = DateTime.UtcNow;
                return dbContext.Update(entity);
            }
        }
    }
}

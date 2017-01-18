using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sol.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.RelationalDb.Extensions
{
    public static class SolEntityExtensions
    {
        public static EntityTypeBuilder<T> AsInt32Entity<T>(this EntityTypeBuilder<T> builder) where T: Int32EntityBase
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Timestamp)
            .ValueGeneratedOnAddOrUpdate()
            .IsConcurrencyToken();
            return builder;
        }
    }
}

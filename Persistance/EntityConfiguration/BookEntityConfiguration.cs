using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Data.Entity.ModelConfiguration;


namespace Persistance.EntityConfiguration
{
    public class BookEntityConfiguration : EntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}

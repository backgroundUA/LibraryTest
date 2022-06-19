using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Data.Entity.ModelConfiguration;

namespace Persistance.EntityConfiguration
{
    public class ReaderEntityConfiguration : EntityTypeConfiguration<ReaderEntity>
    {
        public void Configure(EntityTypeBuilder<ReaderEntity> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}

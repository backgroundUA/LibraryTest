using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

using System.Data.Entity.ModelConfiguration;


namespace Persistance.EntityConfiguration
{
    public class LibrarianEntityConfiguration : EntityTypeConfiguration<LibrarianEntity>
    {
        public void Configure(EntityTypeBuilder<LibrarianEntity> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}

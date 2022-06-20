using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<ReaderEntity> Readers { get; set; }
        public DbSet<LibrarianEntity> Librarians { get; set; }

        
        
        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AuthorEntity>(AuthorEntityConfiguration);
            builder.Entity<BookEntity>(BookEntityConfiguration);
            builder.Entity<LibrarianEntity>(LibrarianEntityConfiguration);
            builder.Entity<ReaderEntity>(ReaderEntityConfiguration);
        }

        #region EntityConfiguration
        public void AuthorEntityConfiguration(EntityTypeBuilder<AuthorEntity> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.MidleName);
            builder.HasIndex(x => x.FirstName);
            builder.HasIndex(x => x.LastName);
            builder.HasIndex(x => x.Age);
        }
        public void BookEntityConfiguration(EntityTypeBuilder<BookEntity> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
        }
        public void LibrarianEntityConfiguration(EntityTypeBuilder<LibrarianEntity> builder)
        {
            builder.ToTable("Librarians");
            builder.HasKey(x => x.Id);
        }
        public void ReaderEntityConfiguration(EntityTypeBuilder<ReaderEntity> builder)
        {
            builder.ToTable("Readers");
            builder.HasKey(x => x.Id);
        }

        #endregion
    }
}
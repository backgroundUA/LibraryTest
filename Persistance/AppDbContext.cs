using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.EntityConfiguration;

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
        public DbSet<LibrarianEntity> Libraryans { get; set; }


        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AuthorEntityConfiguration());
            builder.ApplyConfiguration(new BookEntityConfiguration());
            builder.ApplyConfiguration(new LibrarianEntityConfiguration());
            builder.ApplyConfiguration(new ReaderEntityConfiguration());
        }

       

       
    }
}
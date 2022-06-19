using System;

namespace Domain.Entities
{
    public class ReaderEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<BookEntity> Books { get; set; }
        public List<AuthorEntity> Authors { get; set; }
    }
}

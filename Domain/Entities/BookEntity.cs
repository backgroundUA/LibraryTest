using System;


namespace Domain.Entities
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime YearBook { get; set; }
        public AuthorEntity Author { get; set; }


        public BookEntity()
        { }

        public BookEntity(string title, string genre, DateTime yearBook, AuthorEntity author)
        {
            Title = title;
            Genre = genre;
            YearBook = yearBook;
            Author = author;
        }
    } 
}   

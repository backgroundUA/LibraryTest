using System;


namespace Domain.Entities
{
    public class AuthorEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MidleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthData { get; set; }
        public DateTime DataOfDeath { get; set; }


        public List<BookEntity> Books { get; set; }


        public AuthorEntity()
        {
        }

        public AuthorEntity(string firstName, string midleName, string lastName, DateTime dateTime, DateTime dateOfDeath)
        {
            FirstName = firstName;
            MidleName = midleName;
            LastName = lastName;
            BirthData = dateTime;
            DataOfDeath = dateOfDeath;
        }
    }
}

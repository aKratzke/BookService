namespace BookService.Migrations
{
    using BookService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            context.Authors.AddOrUpdate(x => x.ID,
                new Author() { ID = 1, Name = "Jane Austen" },
                new Author() { ID = 2, Name = "Charles Dickens" },
                new Author() { ID = 3, Name = "Miguel de Cervantes" }
                );

            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, Title = "Pride and Prejudice", Year = 1813, AuthorID = 1, Price = 9.99M, Genre = "Comedy of Manners" },
                new Book() { Id = 2, Title = "Northanger Abbey", Year = 1817, AuthorID = 1, Price = 12.95M, Genre = "Gothic Parody" },
                new Book() { Id = 3, Title = "David Copperfield", Year = 1850, AuthorID = 2, Price = 15, Genre = "Bildungsroman" },
                new Book() { Id = 4, Title = "Don Quixote", Year = 1617, AuthorID = 3, Price = 8.95M, Genre = "Picaresque" }
                );
        }
    }
}

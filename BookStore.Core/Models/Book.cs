using System;

namespace BookStore.Core.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public Guid AuthorId { get; set; }
        public int Stock { get; set; }

        public Book(Guid id, string title, string isbn, Guid authorId, int stock)
        {
            Id = id;
            Title = title;
            Isbn = isbn;
            AuthorId = authorId;
            Stock = stock;
        }
    }
}

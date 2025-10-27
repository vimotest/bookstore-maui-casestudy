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
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Isbn = isbn ?? throw new ArgumentNullException(nameof(isbn));
            AuthorId = authorId;
            Stock = stock >= 0 ? stock : throw new ArgumentOutOfRangeException(nameof(stock), "Stock cannot be negative");
        }
    }
}

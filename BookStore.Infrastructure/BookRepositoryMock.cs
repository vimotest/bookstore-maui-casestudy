using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Core.Models;
using BookStore.Core.Repositories;

namespace BookStore.Infrastructure
{
    /// <summary>
    /// Mock implementation of IBookRepository for testing and development purposes.
    /// Uses an in-memory list to simulate data persistence.
    /// </summary>
    public class BookRepositoryMock : IBookRepository
    {
        private static readonly List<Book> _books = new List<Book>();

        static BookRepositoryMock()
        {
            ResetToInitialState();
        }

        /// <summary>
        /// Resets the repository to its initial state with sample books.
        /// This is useful for testing purposes to ensure a clean state.
        /// </summary>
        public static void ResetToInitialState()
        {
            _books.Clear();
            _books.Add(new Book(
                Guid.Parse("11111111-1111-1111-1111-111111111111"),
                "The Great Gatsby",
                "978-0-7432-7356-5",
                Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                10
            ));
            _books.Add(new Book(
                Guid.Parse("22222222-2222-2222-2222-222222222222"),
                "To Kill a Mockingbird",
                "978-0-06-112008-4",
                Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                5
            ));
            _books.Add(new Book(
                Guid.Parse("33333333-3333-3333-3333-333333333333"),
                "1984",
                "978-0-452-28423-4",
                Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                8
            ));
        }

        /// <inheritdoc />
        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return Task.FromResult<IEnumerable<Book>>(_books.ToList());
        }

        /// <inheritdoc />
        public Task<Book?> GetBookByIdAsync(Guid id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            return Task.FromResult<Book?>(book);
        }

        /// <inheritdoc />
        public Task<Book> AddBookAsync(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _books.Add(book);
            return Task.FromResult(book);
        }

        /// <inheritdoc />
        public Task<Book> UpdateBookAsync(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook == null)
            {
                throw new InvalidOperationException($"Book with ID {book.Id} does not exist in the repository.");
            }

            existingBook.Title = book.Title;
            existingBook.Isbn = book.Isbn;
            existingBook.AuthorId = book.AuthorId;
            existingBook.Stock = book.Stock;

            return Task.FromResult(existingBook);
        }

        /// <inheritdoc />
        public Task<bool> DeleteBookAsync(Guid id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}

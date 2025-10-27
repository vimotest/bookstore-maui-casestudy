using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Core.Models;

namespace BookStore.Core.Repositories
{
    /// <summary>
    /// Repository interface for managing books in the bookstore.
    /// </summary>
    public interface IBookRepository
    {
        /// <summary>
        /// Gets all books from the repository.
        /// </summary>
        /// <returns>A collection of all books.</returns>
        Task<IEnumerable<Book>> GetAllBooksAsync();

        /// <summary>
        /// Gets a book by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The book if found; otherwise, null.</returns>
        Task<Book?> GetBookByIdAsync(Guid id);

        /// <summary>
        /// Adds a new book to the repository.
        /// </summary>
        /// <param name="book">The book to add. Must not be null.</param>
        /// <returns>The added book with any repository-generated values.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when book is null.</exception>
        Task<Book> AddBookAsync(Book book);

        /// <summary>
        /// Updates an existing book in the repository.
        /// </summary>
        /// <param name="book">The book to update. Must not be null and must exist in the repository.</param>
        /// <returns>The updated book.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when book is null.</exception>
        Task<Book> UpdateBookAsync(Book book);

        /// <summary>
        /// Deletes a book from the repository by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the book to delete.</param>
        /// <returns>True if the book was found and deleted; false if the book was not found.</returns>
        Task<bool> DeleteBookAsync(Guid id);
    }
}

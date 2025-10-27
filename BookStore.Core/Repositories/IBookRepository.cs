using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Core.Models;

namespace BookStore.Core.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(Guid id);
        Task<Book> AddBookAsync(Book book);
        Task<Book> UpdateBookAsync(Book book);
        Task<bool> DeleteBookAsync(Guid id);
    }
}

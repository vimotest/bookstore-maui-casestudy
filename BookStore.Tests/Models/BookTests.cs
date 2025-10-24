using BookStore.Core.Models;

namespace BookStore.Tests.Models;

public class BookTests
{
    [Fact]
    public void Constructor_ShouldInitializeProperties()
    {
        // Arrange
        var id = Guid.NewGuid();
        var title = "The Great Gatsby";
        var isbn = "978-0-7432-7356-5";
        var authorId = Guid.NewGuid();
        var stock = 10;

        // Act
        var book = new Book(id, title, isbn, authorId, stock);

        // Assert
        Assert.Equal(id, book.Id);
        Assert.Equal(title, book.Title);
        Assert.Equal(isbn, book.Isbn);
        Assert.Equal(authorId, book.AuthorId);
        Assert.Equal(stock, book.Stock);
    }

    [Fact]
    public void Properties_ShouldBeSettable()
    {
        // Arrange
        var book = new Book(Guid.NewGuid(), "Old Title", "111-1111", Guid.NewGuid(), 5);
        var newId = Guid.NewGuid();
        var newTitle = "New Title";
        var newIsbn = "222-2222";
        var newAuthorId = Guid.NewGuid();
        var newStock = 20;

        // Act
        book.Id = newId;
        book.Title = newTitle;
        book.Isbn = newIsbn;
        book.AuthorId = newAuthorId;
        book.Stock = newStock;

        // Assert
        Assert.Equal(newId, book.Id);
        Assert.Equal(newTitle, book.Title);
        Assert.Equal(newIsbn, book.Isbn);
        Assert.Equal(newAuthorId, book.AuthorId);
        Assert.Equal(newStock, book.Stock);
    }
}

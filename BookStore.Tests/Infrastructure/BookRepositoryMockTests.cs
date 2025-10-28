using BookStore.Core.Models;
using BookStore.Infrastructure;

namespace BookStore.Tests.Infrastructure;

public class BookRepositoryMockTests
{
    [Fact]
    public async Task GetAllBooksAsync_ShouldReturnAllBooks()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();

        // Act
        var books = await repository.GetAllBooksAsync();

        // Assert
        Assert.NotNull(books);
        Assert.NotEmpty(books);
        Assert.Equal(3, books.Count());
    }

    [Fact]
    public async Task GetBookByIdAsync_WithValidId_ShouldReturnBook()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var expectedId = Guid.Parse("11111111-1111-1111-1111-111111111111");

        // Act
        var book = await repository.GetBookByIdAsync(expectedId);

        // Assert
        Assert.NotNull(book);
        Assert.Equal(expectedId, book.Id);
        Assert.Equal("The Great Gatsby", book.Title);
    }

    [Fact]
    public async Task GetBookByIdAsync_WithInvalidId_ShouldReturnNull()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var invalidId = Guid.NewGuid();

        // Act
        var book = await repository.GetBookByIdAsync(invalidId);

        // Assert
        Assert.Null(book);
    }

    [Fact]
    public async Task AddBookAsync_WithValidBook_ShouldAddBook()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var newBook = new Book(
            Guid.NewGuid(),
            "New Book",
            "978-1-234-56789-0",
            Guid.NewGuid(),
            15
        );

        // Act
        var addedBook = await repository.AddBookAsync(newBook);

        // Assert
        Assert.NotNull(addedBook);
        Assert.Equal(newBook.Id, addedBook.Id);
        Assert.Equal(newBook.Title, addedBook.Title);

        // Verify the book was added to the collection
        var books = await repository.GetAllBooksAsync();
        Assert.Contains(books, b => b.Id == newBook.Id);
    }

    [Fact]
    public async Task AddBookAsync_WithNullBook_ShouldThrowArgumentNullException()
    {
        // Arrange
        var repository = new BookRepositoryMock();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => repository.AddBookAsync(null!));
    }

    [Fact]
    public async Task UpdateBookAsync_WithExistingBook_ShouldUpdateBook()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var bookId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        var updatedBook = new Book(
            bookId,
            "Updated Title",
            "978-9-999-99999-9",
            Guid.NewGuid(),
            25
        );

        // Act
        var result = await repository.UpdateBookAsync(updatedBook);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(bookId, result.Id);

        // Verify the book was updated in the collection
        var book = await repository.GetBookByIdAsync(bookId);
        Assert.NotNull(book);
        Assert.Equal("Updated Title", book.Title);
        Assert.Equal("978-9-999-99999-9", book.Isbn);
        Assert.Equal(25, book.Stock);
    }

    [Fact]
    public async Task UpdateBookAsync_WithNonExistingBook_ShouldThrowInvalidOperationException()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var newBookId = Guid.NewGuid();
        var nonExistingBook = new Book(
            newBookId,
            "Non-Existing Book",
            "978-8-888-88888-8",
            Guid.NewGuid(),
            5
        );

        // Act & Assert
        await Assert.ThrowsAsync<InvalidOperationException>(() => repository.UpdateBookAsync(nonExistingBook));
    }

    [Fact]
    public async Task UpdateBookAsync_WithNullBook_ShouldThrowArgumentNullException()
    {
        // Arrange
        var repository = new BookRepositoryMock();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => repository.UpdateBookAsync(null!));
    }

    [Fact]
    public async Task DeleteBookAsync_WithExistingBook_ShouldReturnTrueAndRemoveBook()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var bookId = Guid.Parse("22222222-2222-2222-2222-222222222222");

        // Act
        var result = await repository.DeleteBookAsync(bookId);

        // Assert
        Assert.True(result);

        // Verify the book was removed from the collection
        var book = await repository.GetBookByIdAsync(bookId);
        Assert.Null(book);
    }

    [Fact]
    public async Task DeleteBookAsync_WithNonExistingBook_ShouldReturnFalse()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var invalidId = Guid.NewGuid();

        // Act
        var result = await repository.DeleteBookAsync(invalidId);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public async Task GetAllBooksAsync_ShouldReturnAsynchronously()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();

        // Act
        var task = repository.GetAllBooksAsync();

        // Assert
        Assert.True(task.IsCompleted, "Task should complete synchronously using Task.FromResult");
        var books = await task;
        Assert.NotNull(books);
    }

    [Fact]
    public async Task GetBookByIdAsync_ShouldReturnAsynchronously()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var bookId = Guid.Parse("11111111-1111-1111-1111-111111111111");

        // Act
        var task = repository.GetBookByIdAsync(bookId);

        // Assert
        Assert.True(task.IsCompleted, "Task should complete synchronously using Task.FromResult");
        var book = await task;
        Assert.NotNull(book);
    }

    [Fact]
    public async Task UpdateBookAsync_ShouldReturnAsynchronously()
    {
        // Arrange
        BookRepositoryMock.ResetToInitialState();
        var repository = new BookRepositoryMock();
        var bookId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        var updatedBook = new Book(bookId, "Test Title", "978-0-000-00000-0", Guid.NewGuid(), 10);

        // Act
        var task = repository.UpdateBookAsync(updatedBook);

        // Assert
        Assert.True(task.IsCompleted, "Task should complete synchronously using Task.FromResult");
        var result = await task;
        Assert.NotNull(result);
    }
}

using Xunit;
using BookStore.Core.Models;

namespace BookStore.Tests.Models;

public class AuthorTests
{
    [Fact]
    public void Constructor_ShouldInitializeProperties()
    {
        // Arrange
        var id = Guid.NewGuid();
        var firstName = "John";
        var lastName = "Doe";

        // Act
        var author = new Author(id, firstName, lastName);

        // Assert
        Assert.Equal(id, author.Id);
        Assert.Equal(firstName, author.FirstName);
        Assert.Equal(lastName, author.LastName);
    }

    [Fact]
    public void Properties_ShouldBeSettable()
    {
        // Arrange
        var author = new Author(Guid.NewGuid(), "John", "Doe");
        var newId = Guid.NewGuid();
        var newFirstName = "Jane";
        var newLastName = "Smith";

        // Act
        author.Id = newId;
        author.FirstName = newFirstName;
        author.LastName = newLastName;

        // Assert
        Assert.Equal(newId, author.Id);
        Assert.Equal(newFirstName, author.FirstName);
        Assert.Equal(newLastName, author.LastName);
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentNullException_WhenFirstNameIsNull()
    {
        // Arrange
        var id = Guid.NewGuid();
        string? firstName = null;
        var lastName = "Doe";

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new Author(id, firstName!, lastName));
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentNullException_WhenLastNameIsNull()
    {
        // Arrange
        var id = Guid.NewGuid();
        var firstName = "John";
        string? lastName = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => new Author(id, firstName, lastName!));
    }
}

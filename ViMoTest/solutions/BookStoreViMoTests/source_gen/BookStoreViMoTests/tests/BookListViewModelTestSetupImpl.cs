/// <filename>
///     BookListViewModelTestSetupImpl.cs
/// </filename>

using BookStore.Core.Models;
using BookStore.Core.Repositories;
using Moq;

internal class BookListViewModelTestSetupImpl : BookListViewModelTestSetup
{
    private Mock<IBookRepository>? _mockRepository;
    private List<Book> _testBooks = new List<Book>();

    public override void Init()
    {
        _mockRepository = new Mock<IBookRepository>();
        _testBooks.Clear();
    }

    public override void SetDataTableString(string multiLineString)
    {
        // Parse the table string to extract book data
        // Format: | isbn | name | author | price | stock |
        var lines = multiLineString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var line in lines)
        {
            if (line.Contains("isbn") && line.Contains("name")) continue; // Skip header
            
            var parts = line.Split('|', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length >= 5)
            {
                var isbn = parts[0];
                var name = parts[1];
                var author = parts[2];
                var price = parts[3];
                var stock = int.Parse(parts[4]);
                
                // Create a test book - using a deterministic GUID based on ISBN
                var book = new Book(
                    Guid.NewGuid(),
                    name,
                    isbn,
                    Guid.NewGuid(), // AuthorId
                    stock
                );
                
                _testBooks.Add(book);
            }
        }
    }

    public override BookListViewModel BuildSut()
    {
        if (_mockRepository == null)
        {
            throw new InvalidOperationException("Init must be called before BuildSut");
        }

        // Setup the mock repository to return our test books
        _mockRepository.Setup(r => r.GetAllBooksAsync())
            .ReturnsAsync(_testBooks);

        return new BookStore.ViewModels.BookListViewModelImpl(_mockRepository.Object);
    }
}


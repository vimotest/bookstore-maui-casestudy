using BookStore.Core.Models;
using BookStore.Core.Repositories;
using BookStore.ViewModels;
using Moq;
using Xunit;

namespace BookStore.Tests.ViewModels
{
    public class BookListViewModelImplTests
    {
        [Fact]
        public async Task LoadBooksAsync_ShouldPopulateBooksCollection()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var testBooks = new List<Book>
            {
                new Book(Guid.NewGuid(), "Test Book 1", "111-111", Guid.NewGuid(), 5),
                new Book(Guid.NewGuid(), "Test Book 2", "222-222", Guid.NewGuid(), 10)
            };
            
            mockRepo.Setup(r => r.GetAllBooksAsync()).ReturnsAsync(testBooks);
            
            var viewModel = new BookListViewModelImpl(mockRepo.Object);
            
            // Act
            viewModel.loadView();
            // Wait a bit for async operation
            await Task.Delay(100);
            
            // Assert
            var rows = viewModel.getBookListTableRows();
            Assert.Equal(2, rows.Count);
            Assert.Equal("Test Book 1", rows[0].getTitleLabelText());
            Assert.Equal("Test Book 2", rows[1].getTitleLabelText());
            Assert.Equal("111-111", rows[0].getISBNLabelText());
            Assert.Equal("222-222", rows[1].getISBNLabelText());
        }

        [Fact]
        public void Constructor_ShouldThrowArgumentNullException_WhenRepositoryIsNull()
        {
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new BookListViewModelImpl(null!));
        }

        [Fact]
        public void SelectedChecked_ShouldUpdateRowSelection()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            mockRepo.Setup(r => r.GetAllBooksAsync()).ReturnsAsync(new List<Book>
            {
                new Book(Guid.NewGuid(), "Test Book", "123-456", Guid.NewGuid(), 5)
            });
            
            var viewModel = new BookListViewModelImpl(mockRepo.Object);
            viewModel.loadView();
            
            // Wait for async load
            Task.Delay(100).Wait();
            
            // Act
            viewModel.selectedChecked(0, true);
            
            // Assert
            var rows = viewModel.getBookListTableRows();
            Assert.True(rows[0].getIsSelectedCheckBoxChecked());
        }

        [Fact]
        public void BookListViewModelBookListRowImpl_ShouldExposeOnlyPrimitiveTypes()
        {
            // Arrange
            var row = new BookListViewModelBookListRowImpl
            {
                TitleLabelText = "Test Title",
                AuthorLabelText = "Test Author",
                IsbnLabelText = "123-456",
                PriceLabelText = "10.00 €",
                StockLabelText = "x5",
                IsSelected = true,
                PreviewImageName = "test.png",
                RowHandle = "handle123"
            };
            
            // Assert - verify all properties return primitive types
            Assert.Equal("Test Title", row.getTitleLabelText());
            Assert.Equal("Test Author", row.getAuthorLabelText());
            Assert.Equal("123-456", row.getISBNLabelText());
            Assert.Equal("10.00 €", row.getPriceLabelText());
            Assert.Equal("x5", row.getStockLabelText());
            Assert.True(row.getIsSelectedCheckBoxChecked());
            Assert.Equal("test.png", row.getPreviewImageName());
            Assert.Equal("handle123", row.getRowHandle());
        }
    }
}

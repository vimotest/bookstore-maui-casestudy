using System.Collections.ObjectModel;
using BookStore.Core.Repositories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BookStore.ViewModels
{
    /// <summary>
    /// Implementation of BookListViewModel following the Presentation-Ready ViewModel rule.
    /// Does NOT expose Book domain objects directly - only presentation-ready BookListViewModelBookListRow objects.
    /// </summary>
    [ObservableObject]
    internal partial class BookListViewModelImpl : BookListViewModel
    {
        private readonly IBookRepository _bookRepository;
        private ObservableCollection<BookListViewModelBookListRow> _books = new();

        public ObservableCollection<BookListViewModelBookListRow> Books
        {
            get => _books;
            set => SetProperty(ref _books, value);
        }

        public BookListViewModelImpl(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository ?? throw new ArgumentNullException(nameof(bookRepository));
        }

        public override List<BookListViewModelBookListRow> getBookListTableRows()
        {
            return Books.ToList();
        }

        public override async void loadView()
        {
            await LoadBooksAsync();
        }

        [RelayCommand]
        private async Task LoadBooksAsync()
        {
            var booksFromRepo = await _bookRepository.GetAllBooksAsync();
            
            Books.Clear();
            
            foreach (var book in booksFromRepo)
            {
                var row = new BookListViewModelBookListRowImpl
                {
                    PreviewImageName = $"{book.Title}.png",
                    TitleLabelText = book.Title,
                    AuthorLabelText = "Unknown Author", // TODO: Need to resolve author from AuthorId
                    IsbnLabelText = book.Isbn,
                    PriceLabelText = "0.00 €", // TODO: Book model doesn't have price yet
                    StockLabelText = $"x{book.Stock}",
                    RowHandle = book.Id.ToString(),
                    IsSelected = false
                };
                
                Books.Add(row);
            }
        }

        public override void addClicked()
        {
            // TODO: Implement add functionality
        }

        public override void deleteClicked()
        {
            // TODO: Implement delete functionality
        }

        public override void selectedChecked(int rowIndex, bool isChecked)
        {
            if (rowIndex >= 0 && rowIndex < Books.Count)
            {
                var row = Books[rowIndex] as BookListViewModelBookListRowImpl;
                if (row != null)
                {
                    row.IsSelected = isChecked;
                }
            }
        }
    }
}

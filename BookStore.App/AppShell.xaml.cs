#if !DotNetBuildFromSource
using BookStore.App.Views;

namespace BookStore.App;

/// <summary>
/// The application shell for navigation and flyout menu.
/// </summary>
public partial class AppShell : Shell
{
    /// <summary>
    /// Initializes a new instance of the AppShell class.
    /// </summary>
    /// <param name="bookListView">The book list view injected via DI.</param>
    public AppShell(BookListView bookListView)
    {
        InitializeComponent();

        // Set the BookListView as the content
        BookListShellContent.Content = bookListView;

        // Register route for BookDetailPage
        // TODO: Replace with actual BookDetailPage type when it is created
        // Routing.RegisterRoute("bookdetail", typeof(Views.BookDetailPage));
    }
}
#endif

#if !DotNetBuildFromSource
namespace BookStore.App;

/// <summary>
/// The application shell for navigation and flyout menu.
/// </summary>
public partial class AppShell : Shell
{
    /// <summary>
    /// Initializes a new instance of the AppShell class.
    /// </summary>
    public AppShell()
    {
        InitializeComponent();

        // Register route for BookDetailPage (to be created later)
        Routing.RegisterRoute("bookdetail", typeof(Views.BookListView)); // Placeholder until BookDetailPage is created
    }
}
#endif

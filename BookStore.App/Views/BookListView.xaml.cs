#if !DotNetBuildFromSource
using BookStore.ViewModels;

namespace BookStore.App.Views;

/// <summary>
/// View for displaying the list of books.
/// Follows MVVM pattern with minimal code-behind.
/// </summary>
public partial class BookListView : ContentPage
{
    private readonly BookListViewModelImpl _viewModel;

    /// <summary>
    /// Initializes a new instance of the BookListView class.
    /// </summary>
    /// <param name="viewModel">The view model injected via DI.</param>
    public BookListView(BookListViewModelImpl viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    /// <summary>
    /// Called when the page is appearing. Triggers the ViewModel to load data.
    /// </summary>
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.loadView();
    }
}
#endif

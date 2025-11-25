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
    /// Constructor is internal because the ViewModel type is internal.
    /// </summary>
    /// <param name="viewModel">The view model injected via DI.</param>
    internal BookListView(BookListViewModelImpl viewModel)
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

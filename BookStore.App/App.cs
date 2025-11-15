#if !DotNetBuildFromSource
namespace BookStore.App;

/// <summary>
/// The main application class for the BookStore MAUI app.
/// </summary>
public class App : Application
{
    /// <summary>
    /// Initializes a new instance of the App class.
    /// </summary>
    public App()
    {
        // Placeholder: Main page will be set when Shell is implemented
        MainPage = new ContentPage
        {
            Content = new Label
            {
                Text = "BookStore App - Ready for UI implementation",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        };
    }
}
#endif

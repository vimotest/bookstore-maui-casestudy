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
        MainPage = new AppShell();
    }
}
#endif

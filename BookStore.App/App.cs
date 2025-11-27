#if !DotNetBuildFromSource
namespace BookStore.App;

/// <summary>
/// The main application class for the BookStore MAUI app.
/// </summary>
public class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// Initializes a new instance of the App class.
    /// </summary>
    /// <param name="serviceProvider">The service provider for dependency injection.</param>
    public App(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var shell = _serviceProvider.GetRequiredService<AppShell>();
        return new Window(shell);
    }
}
#endif

#if !DotNetBuildFromSource
using BookStore.Bootstrap;
using Microsoft.Extensions.Logging;

namespace BookStore.App;

/// <summary>
/// Configures and builds the MAUI application with dependency injection.
/// </summary>
public static class MauiProgram
{
    /// <summary>
    /// Creates and configures the MAUI app builder.
    /// </summary>
    /// <returns>A configured MAUI app instance.</returns>
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register services shared across platforms
        builder.Services.AddBookStoreServices();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
#endif

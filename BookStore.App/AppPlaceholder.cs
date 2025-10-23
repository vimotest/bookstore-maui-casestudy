namespace BookStore.App;

/// <summary>
/// Placeholder for BookStore MAUI Application.
/// This project requires the .NET MAUI workload to be installed.
/// To install: dotnet workload install maui
/// 
/// Full MAUI UI components will be added in subsequent development phases.
/// ViewModels and business logic components that don't require UI rendering
/// can be developed and tested without the full MAUI workload.
/// </summary>
public class Program
{
    public const string RequiredWorkload = "maui";
    public const string InstallCommand = "dotnet workload install maui";
    
    // Entry point for fallback mode (when MAUI workload is not available)
    public static void Main(string[] args)
    {
        Console.WriteLine("BookStore.App - MAUI Application");
        Console.WriteLine($"This application requires the {RequiredWorkload} workload.");
        Console.WriteLine($"Install with: {InstallCommand}");
    }
}

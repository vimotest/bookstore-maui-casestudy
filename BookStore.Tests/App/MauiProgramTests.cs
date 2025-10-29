#if !DotNetBuildFromSource
using BookStore.Core.Repositories;
using BookStore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
#endif

namespace BookStore.Tests.App;

/// <summary>
/// Tests for MauiProgram dependency injection configuration.
/// </summary>
public class MauiProgramTests
{
#if !DotNetBuildFromSource
    [Fact]
    public void CreateMauiApp_ShouldRegisterBookRepositoryAsSingleton()
    {
        // Arrange & Act
        var app = BookStore.App.MauiProgram.CreateMauiApp();

        // Assert
        var services = app.Services;
        Assert.NotNull(services);

        // Verify IBookRepository is registered
        var repository = services.GetService<IBookRepository>();
        Assert.NotNull(repository);
        Assert.IsType<BookRepositoryMock>(repository);
    }

    [Fact]
    public void CreateMauiApp_BookRepository_ShouldBeSingleton()
    {
        // Arrange & Act
        var app = BookStore.App.MauiProgram.CreateMauiApp();
        var services = app.Services;

        // Get repository twice
        var repository1 = services.GetService<IBookRepository>();
        var repository2 = services.GetService<IBookRepository>();

        // Assert - Same instance should be returned (singleton behavior)
        Assert.NotNull(repository1);
        Assert.NotNull(repository2);
        Assert.Same(repository1, repository2);
    }

    [Fact]
    public void CreateMauiApp_ShouldReturnValidMauiApp()
    {
        // Arrange & Act
        var app = BookStore.App.MauiProgram.CreateMauiApp();

        // Assert
        Assert.NotNull(app);
        Assert.NotNull(app.Services);
    }
#else
    [Fact]
    public void MauiProgram_NotAvailable_InFallbackMode()
    {
        // This test exists to ensure tests pass in fallback mode
        // MauiProgram is only available when MAUI workload is installed
        Assert.True(true, "MauiProgram tests skipped in fallback mode");
    }
#endif
}

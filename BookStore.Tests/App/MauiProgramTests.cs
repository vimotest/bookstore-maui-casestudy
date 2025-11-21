using BookStore.Bootstrap;
using BookStore.Core.Repositories;
using BookStore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BookStore.Tests.App;

/// <summary>
/// Tests the platform-agnostic service registration used by the MAUI bootstrapper.
/// </summary>
public class MauiProgramTests
{
    [Fact]
    public void AddBookStoreServices_ShouldRegisterBookRepository()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        services.AddBookStoreServices();
        using var provider = services.BuildServiceProvider();

        // Assert
        var repository = provider.GetService<IBookRepository>();
        Assert.NotNull(repository);
        Assert.IsType<BookRepositoryMock>(repository);
    }

    [Fact]
    public void AddBookStoreServices_ShouldKeepRepositorySingleton()
    {
        // Arrange
        var services = new ServiceCollection();
        services.AddBookStoreServices();
        using var provider = services.BuildServiceProvider();

        // Act
        var instance1 = provider.GetRequiredService<IBookRepository>();
        var instance2 = provider.GetRequiredService<IBookRepository>();

        // Assert
        Assert.Same(instance1, instance2);
    }
}

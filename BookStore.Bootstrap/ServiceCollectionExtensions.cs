using BookStore.Core.Repositories;
using BookStore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Bootstrap;

/// <summary>
/// Configures dependency injection for the BookStore application in a platform-agnostic way.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers shared application services.
    /// </summary>
    public static IServiceCollection AddBookStoreServices(this IServiceCollection services)
    {
        services.AddSingleton<IBookRepository, BookRepositoryMock>();
        return services;
    }
}

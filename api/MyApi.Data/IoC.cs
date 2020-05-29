using Microsoft.Extensions.DependencyInjection;
using MyApi.Data.Repositories;

namespace MyApi.Data
{
    public static class IoC
    {
        public static IServiceCollection AddDataRepositories(this IServiceCollection services)
        {
            return services
                .AddDbContext<LibraryContext>(ServiceLifetime.Transient) // Create new instance per query
                .AddTransient<IAuthorRepository, AuthorRepository>()
                .AddTransient<IBookRepository, BookRepository>()
                .AddTransient<IBookReviewRepository, BookReviewRepository>();
        }
    }
}

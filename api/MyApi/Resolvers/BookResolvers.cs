using System.Threading.Tasks;
using GreenDonut;
using HotChocolate;
using MyApi.Data.Entities;
using MyApi.DataLoaders;

namespace MyApi.Resolvers
{
    public class BookResolvers
    {
        public Task<Author> GetAuthor([DataLoader] AuthorDataLoader dataLoader, [Parent] Book book)
        {
            return dataLoader.LoadAsync(book.AuthorId);
        }
    }
}

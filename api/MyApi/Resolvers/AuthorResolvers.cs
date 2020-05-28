using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;

namespace MyApi.Resolvers
{
    public class AuthorResolvers
    {
        public IEnumerable<Book> GetBooks([Service] IBookRepository bookRepository, [Parent] Author author)
        {
            return bookRepository.FindAll().Where(x => x.AuthorId == author.Id);
        }
    }
}

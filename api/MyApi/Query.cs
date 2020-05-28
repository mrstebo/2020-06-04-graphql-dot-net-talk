using System.Collections.Generic;
using HotChocolate;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;

namespace MyApi
{
    public class Query
    {
        public IEnumerable<Author> GetAuthors([Service] IAuthorRepository repository) => repository.FindAll();
        public Author GetAuthor([Service] IAuthorRepository repository, long id) => repository.FindById(id);

        public IEnumerable<Book> GetBooks([Service] IBookRepository repository) => repository.FindAll();
        public Book GetBook([Service] IBookRepository repository, long id) => repository.FindById(id);
    }
}

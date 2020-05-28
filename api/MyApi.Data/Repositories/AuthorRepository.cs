using System.Linq;
using MyApi.Data.Entities;

namespace MyApi.Data.Repositories
{
    public interface IAuthorRepository
    {
        IQueryable<Author> FindAll();
        Author FindById(long id);
    }

    internal class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public IQueryable<Author> FindAll()
        {
            return _context.Authors;
        }

        public Author FindById(long id)
        {
            return _context.Authors.Find(id);
        }
    }
}

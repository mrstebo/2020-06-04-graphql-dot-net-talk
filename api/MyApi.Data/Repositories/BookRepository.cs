using System.Linq;
using MyApi.Data.Entities;

namespace MyApi.Data.Repositories
{
    public interface IBookRepository
    {
        IQueryable<Book> FindAll();
        Book FindById(long id);
    }

    internal class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public IQueryable<Book> FindAll()
        {
            return _context.Books;
        }

        public Book FindById(long id)
        {
            return _context.Books.Find(id);
        }
    }
}

using System.Linq;
using MyApi.Data.Entities;

namespace MyApi.Data.Repositories
{
    public interface IBookReviewRepository
    {
        IQueryable<BookReview> FindAll();
    }

    internal class BookReviewRepository : IBookReviewRepository
    {
        private readonly LibraryContext _context;

        public BookReviewRepository(LibraryContext context)
        {
            _context = context;
        }

        public IQueryable<BookReview> FindAll()
        {
            return _context.BookReviews;
        }
    }
}

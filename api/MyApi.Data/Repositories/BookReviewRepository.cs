using System.Linq;
using MyApi.Data.Entities;

namespace MyApi.Data.Repositories
{
    public interface IBookReviewRepository
    {
        IQueryable<BookReview> FindAll();
        BookReview Create(BookReview bookReview);
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

        public BookReview Create(BookReview bookReview)
        {
            var newBookReview = new BookReview
            {
                BookId = bookReview.BookId,
                Name = bookReview.Name,
                Title = bookReview.Title,
                Content = bookReview.Content
            };

            _context.BookReviews.Add(newBookReview);
            _context.SaveChanges();

            return newBookReview;
        }
    }
}

using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Subscriptions;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;
using MyApi.EventMessages;
using MyApi.Inputs;

namespace MyApi
{
    public class Mutation
    {
        public async Task<BookReview> CreateBookReview(
            [Service] IEventSender eventSender,
            [Service] IBookReviewRepository repository,
            CreateBookReviewInput input
        )
        {
            var bookReview = repository.Create(new BookReview
            {
                BookId = input.BookId,
                Name = input.Name,
                Title = input.Title,
                Content = input.Content
            });

            await eventSender.SendAsync(new OnBookReviewAddedMessage(input.BookId, bookReview));

            return bookReview;
        }
    }
}

using HotChocolate.Subscriptions;
using MyApi.Data.Entities;

namespace MyApi
{
    public class Subscription
    {
        public BookReview OnBookReviewAdded(long bookId, IEventMessage message)
        {
            return (BookReview)message.Payload;
        }
    }
}

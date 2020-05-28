using HotChocolate.Subscriptions;
using MyApi.Data.Entities;

namespace MyApi
{
    public class Subscription
    {
        public BookReview OnBookReview(IEventMessage message)
        {
            return (BookReview)message.Payload;
        }
    }
}

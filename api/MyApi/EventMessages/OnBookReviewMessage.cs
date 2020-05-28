using HotChocolate.Subscriptions;
using MyApi.Data.Entities;

namespace MyApi.EventMessages
{
    public class OnBookReviewMessage : EventMessage
    {
        public OnBookReviewMessage(BookReview bookReview)
            : base(CreateEventDescription(), bookReview)
        {
        }

        private static EventDescription CreateEventDescription()
        {
            return new EventDescription("onBookReview");
        }
    }
}

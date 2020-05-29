using HotChocolate.Language;
using HotChocolate.Subscriptions;
using MyApi.Data.Entities;

namespace MyApi.EventMessages
{
    public class OnBookReviewAddedMessage : EventMessage
    {
        public OnBookReviewAddedMessage(long bookId, BookReview bookReview)
            : base(CreateEventDescription(bookId), bookReview)
        {
        }

        private static EventDescription CreateEventDescription(long bookId)
        {
            return new EventDescription("onBookReviewAdded",
                new ArgumentNode("bookId",
                    new IntValueNode(bookId)));
        }
    }
}

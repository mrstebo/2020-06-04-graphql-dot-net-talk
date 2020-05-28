using HotChocolate.Types;

namespace MyApi.Types
{
    public class SubscriptionType : ObjectType<Subscription>
    {
        protected override void Configure(IObjectTypeDescriptor<Subscription> descriptor)
        {
            descriptor.Field(t => t.OnBookReview(default!))
                .Type<NonNullType<BookReviewType>>();
        }
    }
}

using HotChocolate.Types;

namespace MyApi.Types
{
    public class SubscriptionType : ObjectType<Subscription>
    {
        protected override void Configure(IObjectTypeDescriptor<Subscription> descriptor)
        {
            descriptor.Field(t => t.OnBookReviewAdded(default!, default!))
                .Type<NonNullType<BookReviewType>>()
                .Argument("bookId", arg => arg.Type<NonNullType<LongType>>());
        }
    }
}

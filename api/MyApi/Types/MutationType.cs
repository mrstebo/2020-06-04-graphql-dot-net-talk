using HotChocolate.Types;

namespace MyApi.Types
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(t => t.CreateBookReview(default!, default!, default!))
                .Type<NonNullType<BookReviewType>>()
                .Argument("input", arg => arg.Type<NonNullType<CreateBookReviewInputType>>());
        }
    }
}

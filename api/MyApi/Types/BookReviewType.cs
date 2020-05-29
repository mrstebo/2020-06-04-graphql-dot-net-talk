using HotChocolate.Types;
using MyApi.Data.Entities;
using MyApi.Resolvers;

namespace MyApi.Types
{
    public class BookReviewType : ObjectType<BookReview>
    {
        protected override void Configure(IObjectTypeDescriptor<BookReview> descriptor)
        {
            descriptor.Field(t => t.Id)
                .Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Name)
                .Type<NonNullType<StringType>>()
                .Description("The name of the reviewer");
            descriptor.Field(t => t.Title)
                .Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Content)
                .Type<NonNullType<StringType>>();

            descriptor.Ignore(t => t.BookId);
        }
    }
}

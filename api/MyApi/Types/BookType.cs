using HotChocolate.Types;
using MyApi.Data.Entities;
using MyApi.Resolvers;

namespace MyApi.Types
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field(t => t.Id)
                .Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Name)
                .Type<NonNullType<StringType>>()
                .Description("The name of the book");
            descriptor.Field(t => t.ImageUrl)
                .Type<StringType>();
            descriptor.Field(t => t.Description)
                .Type<StringType>();

            descriptor.Include<BookResolvers>();
        }
    }
}

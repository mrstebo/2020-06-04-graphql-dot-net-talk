using HotChocolate.Types;

namespace MyApi.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetAuthors(default!))
                .Type<NonNullType<ListType<AuthorType>>>();
            descriptor.Field(t => t.GetAuthor(default!, default))
                .Type<NonNullType<AuthorType>>();
            descriptor.Field(t => t.GetBooks(default!))
                .Type<NonNullType<ListType<BookType>>>();
            descriptor.Field(t => t.GetBook(default!, default))
                .Type<NonNullType<BookType>>();
        }
    }
}

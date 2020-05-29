using HotChocolate.Types;

namespace MyApi.Types
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetAuthors(default!))
                .Type<NonNullType<ListType<AuthorType>>>()
                .UseSorting();
            descriptor.Field(t => t.GetAuthor(default!, default))
                .Type<NonNullType<AuthorType>>()
                .Argument("id", arg => arg.Type<IdType>());

            descriptor.Field(t => t.GetBooks(default!))
                .Type<NonNullType<ListType<BookType>>>()
                .UseSorting();
            descriptor.Field(t => t.GetBook(default!, default))
                .Type<NonNullType<BookType>>()
                .Argument("id", arg => arg.Type<IdType>());
        }
    }
}

using System.Linq;
using HotChocolate.Types;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;
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

            descriptor.Ignore(t => t.AuthorId);

            descriptor.Field(t => t.Reviews)
                .Type<NonNullType<ListType<BookReviewType>>>()
                .Argument("skip", arg => arg.Type<IntType>())
                .Argument("first", arg => arg.Type<IntType>())
                .Resolver(ctx =>
                {
                    var repository = ctx.Service<IBookReviewRepository>();
                    var book = ctx.Parent<Book>();
                    var skip = ctx.Argument<int?>("skip") ?? 0;
                    var first = ctx.Argument<int?>("first") ?? 100;

                    return repository.FindAll()
                        .Where(x => x.BookId == book.Id)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip(skip)
                        .Take(first);
                });

            descriptor.Include<BookResolvers>();
        }
    }
}

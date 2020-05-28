using System.Linq;
using HotChocolate.Types;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;
using MyApi.Resolvers;

namespace MyApi.Types
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor.Field(t => t.Id)
                .Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Name)
                .Type<NonNullType<StringType>>()
                .Description("The name of the author");
            descriptor.Field(t => t.ImageUrl)
                .Type<StringType>();

            descriptor.Field("bookCount")
                .Type<IntType>()
                .Resolver(ctx =>
                {
                    var repository = ctx.Service<IBookRepository>();
                    var author = ctx.Parent<Author>();

                    return repository.FindAll().Count(x => x.AuthorId == author.Id);
                });

            descriptor.Include<AuthorResolvers>();
        }
    }
}

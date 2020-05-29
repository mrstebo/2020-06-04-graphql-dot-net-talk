using HotChocolate.Types;
using MyApi.Inputs;

namespace MyApi.Types
{
    public class CreateBookReviewInputType : InputObjectType<CreateBookReviewInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CreateBookReviewInput> descriptor)
        {
            descriptor.Field(t => t.BookId)
                .Type<NonNullType<IdType>>();
            descriptor.Field(t => t.Name)
                .Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Title)
                .Type<NonNullType<StringType>>();
            descriptor.Field(t => t.Content)
                .Type<NonNullType<StringType>>();
        }
    }
}

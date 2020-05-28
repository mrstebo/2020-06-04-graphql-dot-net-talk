using HotChocolate;
using MyApi.Data.Entities;
using MyApi.Data.Repositories;
using MyApi.Inputs;

namespace MyApi
{
    public class Mutation
    {
        public BookReview CreateBookReview([Service] IBookReviewRepository repository, CreateBookReviewInput input)
        {
            return repository.Create(new BookReview
            {
                BookId = input.BookId,
                Name = input.Name,
                Title = input.Title,
                Content = input.Content
            });
        }
    }
}

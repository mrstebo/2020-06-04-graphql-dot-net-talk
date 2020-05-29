namespace MyApi.Inputs
{
    public class CreateBookReviewInput
    {
        public long BookId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

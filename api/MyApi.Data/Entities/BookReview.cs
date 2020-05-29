using System;

namespace MyApi.Data.Entities
{
    public class BookReview
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public long BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}

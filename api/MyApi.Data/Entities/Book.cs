using System.Collections.Generic;

namespace MyApi.Data.Entities
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public long AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public virtual ICollection<BookReview> Reviews { get; set; }
    }
}

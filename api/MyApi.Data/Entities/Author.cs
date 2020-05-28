using System.Collections.Generic;

namespace MyApi.Data.Entities
{
    public class Author
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}

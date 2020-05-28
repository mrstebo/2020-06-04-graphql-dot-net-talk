using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApi.Data.Entities;

namespace MyApi.Data.TypeConfigurations
{
    internal class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("id");
            builder.Property(m => m.Name)
                .HasColumnName("name")
                .IsRequired();
            builder.Property(m => m.ImageUrl)
                .HasColumnName("image_url");
            builder.Property(m => m.AuthorId)
                .HasColumnName("author_id")
                .IsRequired();

            builder.HasOne(m => m.Author)
                .WithMany(m => m.Books)
                .HasForeignKey(m => m.AuthorId);
            builder.HasMany(m => m.Reviews)
                .WithOne(m => m.Book);
        }
    }
}

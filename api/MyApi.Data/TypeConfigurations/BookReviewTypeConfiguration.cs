using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApi.Data.Entities;

namespace MyApi.Data.TypeConfigurations
{
    internal class BookReviewEntityTypeConfiguration : IEntityTypeConfiguration<BookReview>
    {
        public void Configure(EntityTypeBuilder<BookReview> builder)
        {
            builder.ToTable("book_reviews");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("id");

            builder.Property(m => m.Name)
                .HasColumnName("name")
                .IsRequired();
            builder.Property(m => m.Title)
                .HasColumnName("title")
                .IsRequired();
            builder.Property(m => m.Content)
                .HasColumnName("content")
                .IsRequired();
            builder.Property(m => m.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();
            builder.Property(m => m.BookId)
                .HasColumnName("book_id")
                .IsRequired();

            builder.HasOne(m => m.Book)
                .WithMany(m => m.Reviews)
                .HasForeignKey(m => m.BookId);
        }
    }
}

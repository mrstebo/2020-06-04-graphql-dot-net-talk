using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApi.Data.Entities;

namespace MyApi.Data.TypeConfigurations
{
    internal class AuthorEntityTypeConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("authors");

            builder.HasKey(m => m.Id);
            builder.HasIndex(m => m.Name)
                .IsUnique();

            builder.Property(m => m.Id)
                .HasColumnName("id");
            builder.Property(m => m.Name)
                .HasColumnName("name")
                .IsRequired();
            builder.Property(m => m.ImageUrl)
                .HasColumnName("image_url");

            builder.HasMany(m => m.Books)
                .WithOne(m => m.Author)
                .IsRequired();
        }
    }
}

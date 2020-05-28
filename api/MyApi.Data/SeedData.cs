using System.Collections.Generic;
using System.Linq;
using MyApi.Data.Entities;

namespace MyApi.Data
{
    internal static class SeedData
    {
        public static readonly IEnumerable<(Author, Book[])> Data = CreateAuthors();

        private static long _authorId;
        private static long _bookId;

        private static IEnumerable<(Author, Book[])> CreateAuthors()
        {
            _authorId = 1;
            _bookId = 1;

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Robert C. Martin",
                    ImageUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Robert_Cecil_Martin.png/220px-Robert_Cecil_Martin.png"
                },
                new Book
                {
                    Name = "Clean Code: A Handbook of Agile Software Craftsmanship",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Name = "Clean Architecture: A Craftsman's Guide to Software Structure and Design",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/516tg-5b2ZL._SX380_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Name = "Clean Agile: Back to Basics",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/41VQ9-JOXLL._SX380_BO1,204,203,200_.jpg"
                });

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Claus Matzinger",
                    ImageUrl = "https://pbs.twimg.com/profile_images/994220323515101186/zPChlkkM_400x400.jpg"
                },
                new Book
                {
                    Name = "Rust Programming Cookbook",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/51OAK07CVZL._SX404_BO1,204,203,200_.jpg"
                });

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Matt Neuburg",
                    ImageUrl = "https://www.apeth.net/matt/images/recurse.jpg"
                },
                new Book
                {
                    Name = "iOS 13 Programming Fundamentals with Swift: Swift, Xcode, and Cocoa Basics",
                    ImageUrl = "https://m.media-amazon.com/images/I/51pWp9HxK8L._SX260_.jpg"
                });

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Sandi Metz",
                    ImageUrl =
                        "https://images.squarespace-cdn.com/content/v1/537c0374e4b0f52ed92942e6/1480042900353-DL2YPX0HC9ZST40FLRAJ/ke17ZwdGBToddI8pDm48kLR2rgEg1jPu1GtjV4K1vZ97gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0scl71iiVnMuLeEyTFSXT3qwhEKW1IfUKL5GUNLdDa9MjuPXcXiDenG_NSvE-2lGCg/DSC_3772.jpg?format=500w"
                },
                new Book
                {
                    Name = "Practical Object-Oriented Design: An Agile Primer Using Ruby",
                    ImageUrl = "https://m.media-amazon.com/images/I/61qpmhZRxGL._SX260_.jpg"
                });

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Mark J. Price",
                    ImageUrl =
                        "https://avatars3.githubusercontent.com/u/14040265?s=400&u=3e180c29fac400063b2e6032f9c00b2f439a4e2d&v=4"
                },
                new Book
                {
                    Name =
                        "C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development: Build applications with C#, .NET Core, Entity Framework Core, ASP.NET Core, and ML.NET using Visual Studio Code, 4th Edition",
                    ImageUrl = "https://m.media-amazon.com/images/I/51+AEbYTT8L._SX260_.jpg"
                });

            yield return CreateAuthorWithBooks(new Author
                {
                    Name = "Gene Kim",
                    ImageUrl = "https://itrevolution.com/wp-content/uploads/2017/01/gene_kim.png"
                },
                new Book
                {
                    Name = "The Phoenix Project: A Novel about IT, DevOps, and Helping Your Business Win",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/51bAF5pdyeL._SX332_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Name =
                        "The Unicorn Project: A Novel about Developers, Digital Disruption, and Thriving in the Age of Data",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/51A4T36jisL._SX334_BO1,204,203,200_.jpg"
                },
                new Book
                {
                    Name =
                        "The DevOps Handbook: How to Create World-Class Agility, Reliability, and Security in Technology Organizations",
                    ImageUrl =
                        "https://images-na.ssl-images-amazon.com/images/I/51Z6uQ57ilL._SX324_BO1,204,203,200_.jpg"
                });
        }

        private static (Author, Book[]) CreateAuthorWithBooks(Author author, params Book[] books)
        {
            var authorEntity = new Author
            {
                Id = _authorId++,
                Name = author.Name,
                ImageUrl = author.ImageUrl
            };
            var bookEntities = books.Select(book => new Book
            {
                Id = _bookId++,
                AuthorId = authorEntity.Id,
                Name = book.Name,
                ImageUrl = book.ImageUrl
            }).ToArray();

            return (authorEntity, bookEntities);
        }
    }
}

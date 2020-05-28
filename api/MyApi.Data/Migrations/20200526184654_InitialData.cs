using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApi.Data.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "authors",
                new[] {"id", "name"},
                new object[,]
                {
                    {1L, "Robert C. Martin"},
                    {2L, "Claus Matzinger"},
                    {3L, "Matt Neuburg"},
                    {4L, "Sandi Metz"},
                    {5L, "Mark J. Price"},
                    {6L, "Gene Kim"}
                });

            migrationBuilder.InsertData(
                "books",
                new[] {"id", "author_id", "name"},
                new object[,]
                {
                    {1L, 1L, "Clean Code: A Handbook of Agile Software Craftsmanship"},
                    {2L, 1L, "Clean Architecture: A Craftsman's Guide to Software Structure and Design"},
                    {3L, 1L, "Clean Agile: Back to Basics"},
                    {4L, 2L, "Rust Programming Cookbook"},
                    {5L, 3L, "iOS 13 Programming Fundamentals with Swift: Swift, Xcode, and Cocoa Basics"},
                    {6L, 4L, "Practical Object-Oriented Design: An Agile Primer Using Ruby"},
                    {
                        7L, 5L,
                        "C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development: Build applications with C#, .NET Core, Entity Framework Core, ASP.NET Core, and ML.NET using Visual Studio Code, 4th Edition"
                    },
                    {8L, 6L, "The Phoenix Project: A Novel about IT, DevOps, and Helping Your Business Win"},
                    {
                        9L, 6L,
                        "The Unicorn Project: A Novel about Developers, Digital Disruption, and Thriving in the Age of Data"
                    },
                    {
                        10L, 6L,
                        "The DevOps Handbook: How to Create World-Class Agility, Reliability, and Security in Technology Organizations"
                    }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "books",
                "id",
                1L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                2L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                3L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                4L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                5L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                6L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                7L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                8L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                9L);

            migrationBuilder.DeleteData(
                "books",
                "id",
                10L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                1L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                2L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                3L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                4L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                5L);

            migrationBuilder.DeleteData(
                "authors",
                "id",
                6L);
        }
    }
}
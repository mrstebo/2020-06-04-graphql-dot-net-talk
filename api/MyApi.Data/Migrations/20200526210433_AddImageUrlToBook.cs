using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApi.Data.Migrations
{
    public partial class AddImageUrlToBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "books",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "books",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "authors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 1L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 2L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/516tg-5b2ZL._SX380_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 3L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/41VQ9-JOXLL._SX380_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/51OAK07CVZL._SX404_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://m.media-amazon.com/images/I/51pWp9HxK8L._SX260_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://m.media-amazon.com/images/I/61qpmhZRxGL._SX260_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 7L,
                column: "image_url",
                value: "https://m.media-amazon.com/images/I/51+AEbYTT8L._SX260_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 8L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/51bAF5pdyeL._SX332_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 9L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/51A4T36jisL._SX334_BO1,204,203,200_.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "id",
                keyValue: 10L,
                column: "image_url",
                value: "https://images-na.ssl-images-amazon.com/images/I/51Z6uQ57ilL._SX324_BO1,204,203,200_.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "books");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "books",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "authors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApi.Data.Migrations
{
    public partial class AddImageUrlToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "authors",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 1L,
                column: "image_url",
                value: "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ee/Robert_Cecil_Martin.png/220px-Robert_Cecil_Martin.png");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 2L,
                column: "image_url",
                value: "https://pbs.twimg.com/profile_images/994220323515101186/zPChlkkM_400x400.jpg");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 3L,
                column: "image_url",
                value: "https://www.apeth.net/matt/images/recurse.jpg");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 4L,
                column: "image_url",
                value: "https://images.squarespace-cdn.com/content/v1/537c0374e4b0f52ed92942e6/1480042900353-DL2YPX0HC9ZST40FLRAJ/ke17ZwdGBToddI8pDm48kLR2rgEg1jPu1GtjV4K1vZ97gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0scl71iiVnMuLeEyTFSXT3qwhEKW1IfUKL5GUNLdDa9MjuPXcXiDenG_NSvE-2lGCg/DSC_3772.jpg?format=500w");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 5L,
                column: "image_url",
                value: "https://avatars3.githubusercontent.com/u/14040265?s=400&u=3e180c29fac400063b2e6032f9c00b2f439a4e2d&v=4");

            migrationBuilder.UpdateData(
                table: "authors",
                keyColumn: "id",
                keyValue: 6L,
                column: "image_url",
                value: "https://itrevolution.com/wp-content/uploads/2017/01/gene_kim.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "authors");
        }
    }
}

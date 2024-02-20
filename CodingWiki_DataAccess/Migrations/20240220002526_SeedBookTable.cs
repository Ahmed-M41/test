#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class SeedBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "123ASD", 10.99m, "Spider without duty" },
                    { 2, "231DES", 11.99m, "Fortune of time" },
                    { 3, "123ASD", 20.99m, "Fake sunday" },
                    { 4, "AS241", 21.99m, "Cookie jar" },
                    { 5, "12D43", 25.99m, "Cloudy forest" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);
        }
    }
}

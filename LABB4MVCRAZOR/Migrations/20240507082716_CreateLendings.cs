using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LABB4MVCRAZOR.Migrations
{
    /// <inheritdoc />
    public partial class CreateLendings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 5, "Eva Rönnberg", 2010, "Food History" },
                    { 6, "Liv Bergman", 1967, "Survive In The Forest" },
                    { 7, "Gunnar Olsen", 2015, "Fishing Guide" },
                    { 8, "Malin Gullikson", 2006, "How to Saving Money" },
                    { 9, "Tobbe Trollkarl", 2001, "Abrakadabra" }
                });

            migrationBuilder.InsertData(
                table: "Lendings",
                columns: new[] { "LendingId", "BookId", "CustomerId", "LendDate", "ReturnDate", "Returned" },
                values: new object[,]
                {
                    { 5, 5, 4, new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 6, 6, 4, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 7, 7, 5, new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 8, 5, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 9, 6, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);
        }
    }
}

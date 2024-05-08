using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LABB4MVCRAZOR.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Lendings",
                columns: table => new
                {
                    LendingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    LendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Returned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lendings", x => x.LendingId);
                    table.ForeignKey(
                        name: "FK_Lendings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lendings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 1, "Evelyn Larson", 1996, "A day in the country" },
                    { 2, "Lily.P", 1990, "The Dog's Preference: A Human's Guide" },
                    { 3, "Ella Hermansson", 2000, "Lovely Life of Ella" },
                    { 4, "Fredrick Allingås", 2005, "Coding Mastery in a Month" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerName", "Email", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Viktoria Wallström", "viktoria-wallstrom@hotmail.com", "0701234567" },
                    { 2, "Nelly Nordlund", "nellynordlund@gmail.com", "0702345678" },
                    { 3, "Kelly Olsson", "kellyolsson@hotmail.com", "0703456789" }
                });

            migrationBuilder.InsertData(
                table: "Lendings",
                columns: new[] { "LendingId", "BookId", "CustomerId", "LendDate", "ReturnDate", "Returned" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 1, 1, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 3, 3, 2, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, 4, 3, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lendings_BookId",
                table: "Lendings",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendings_CustomerId",
                table: "Lendings",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lendings");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LABB4MVCRAZOR.Migrations
{
    /// <inheritdoc />
    public partial class lendings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 2,
                column: "BookId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Lendings",
                keyColumn: "LendingId",
                keyValue: 2,
                column: "BookId",
                value: 1);
        }
    }
}

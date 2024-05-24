using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DomApp.Migrations
{
    /// <inheritdoc />
    public partial class MasterInstrument3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "395d378c-896d-45ab-8913-08638b417cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b01de8f-abb0-405e-b9e1-c047890b3373");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a5971e7-0ee5-40e0-837c-1385e50a0478", null, "User", "USER" },
                    { "a1912ad3-d1dd-4397-b1e7-43fe216d0d85", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a5971e7-0ee5-40e0-837c-1385e50a0478");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1912ad3-d1dd-4397-b1e7-43fe216d0d85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "395d378c-896d-45ab-8913-08638b417cb0", null, "User", "USER" },
                    { "4b01de8f-abb0-405e-b9e1-c047890b3373", null, "Admin", "ADMIN" }
                });
        }
    }
}

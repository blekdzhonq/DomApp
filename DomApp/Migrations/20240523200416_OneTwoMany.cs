using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DomApp.Migrations
{
    /// <inheritdoc />
    public partial class OneTwoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d5f5de2-8517-4ddb-80ed-d463b49fdc20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "610a02c1-2596-4377-a313-249b5499a8dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59dfe559-f8e3-4c0b-94a5-7a9c65ad22e1", null, "User", "USER" },
                    { "a913f619-7480-4153-8ba0-07f2f8b33eee", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59dfe559-f8e3-4c0b-94a5-7a9c65ad22e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a913f619-7480-4153-8ba0-07f2f8b33eee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d5f5de2-8517-4ddb-80ed-d463b49fdc20", null, "User", "USER" },
                    { "610a02c1-2596-4377-a313-249b5499a8dd", null, "Admin", "ADMIN" }
                });
        }
    }
}

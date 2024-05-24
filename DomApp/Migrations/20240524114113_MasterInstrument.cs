using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DomApp.Migrations
{
    /// <inheritdoc />
    public partial class MasterInstrument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59dfe559-f8e3-4c0b-94a5-7a9c65ad22e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a913f619-7480-4153-8ba0-07f2f8b33eee");

            migrationBuilder.DropColumn(
                name: "TickSize",
                table: "Instruments");

            migrationBuilder.CreateTable(
                name: "MasterInstruments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TickSize = table.Column<decimal>(type: "numeric", nullable: false),
                    PointValue = table.Column<decimal>(type: "numeric", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterInstruments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "395d378c-896d-45ab-8913-08638b417cb0", null, "User", "USER" },
                    { "4b01de8f-abb0-405e-b9e1-c047890b3373", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterInstruments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "395d378c-896d-45ab-8913-08638b417cb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b01de8f-abb0-405e-b9e1-c047890b3373");

            migrationBuilder.AddColumn<decimal>(
                name: "TickSize",
                table: "Instruments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59dfe559-f8e3-4c0b-94a5-7a9c65ad22e1", null, "User", "USER" },
                    { "a913f619-7480-4153-8ba0-07f2f8b33eee", null, "Admin", "ADMIN" }
                });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TestWebApp.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2L, "200" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "GroupId", "Name" },
                values: new object[] { 2L, 1L, "Bub" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "GroupId", "Name" },
                values: new object[] { 3L, 2L, "Beb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}

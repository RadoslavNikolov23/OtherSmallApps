using Microsoft.EntityFrameworkCore.Migrations;

namespace DEA_Program.Data.Migrations
{
    public partial class SeedDbUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DbUsers",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[] { 1, "admin", 0, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DbUsers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

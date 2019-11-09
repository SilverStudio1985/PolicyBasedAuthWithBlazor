using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAuthorization.Server.Data.Migations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85f6ebd9-20ef-4685-a872-6502dca70564", "2370d212-cfab-40fa-a1e5-9a621e7925ff", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0963e9f5-fa26-47bc-afd1-c1a2eab5136c", "30dc292e-5af0-432a-98dc-05f22c00349a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0963e9f5-fa26-47bc-afd1-c1a2eab5136c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85f6ebd9-20ef-4685-a872-6502dca70564");
        }
    }
}

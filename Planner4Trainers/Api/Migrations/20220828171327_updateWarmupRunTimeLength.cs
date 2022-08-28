using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class updateWarmupRunTimeLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 90);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 10);
        }
    }
}

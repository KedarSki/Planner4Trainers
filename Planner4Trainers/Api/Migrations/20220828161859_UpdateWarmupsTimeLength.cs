using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class UpdateWarmupsTimeLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TimeLength",
                table: "WarmupOnWalk",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeLength",
                table: "WarmupOnPlace",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "TimeLength",
                table: "WarmupOnGo",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 10);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 30);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TimeLength",
                table: "WarmupOnWalk",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TimeLength",
                table: "WarmupOnPlace",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TimeLength",
                table: "WarmupOnGo",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeLength",
                value: 0.5m);

            migrationBuilder.UpdateData(
                table: "WarmupOnWalk",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeLength",
                value: 0.5m);
        }
    }
}

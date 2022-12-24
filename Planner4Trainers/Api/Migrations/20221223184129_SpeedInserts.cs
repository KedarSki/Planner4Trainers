using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class SpeedInserts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Speed",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "Rounds", "TimeLength" },
                values: new object[,]
                {
                    { 62, "Szybkie serie uderzania na worek po upływie trzydziestu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać 12. Przerwa to również trzydzieści sekund", 13, "Seria na worek 30 sekund", 12, 30 },
                    { 63, "Szybkie serie uderzania na worek po upływie dwudziesty sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać szesnaście. Przerwa powinna wyności czterdzieści sekund.", 13, "Seria na worek 20 sekund", 16, 20 },
                    { 64, "Szybkie serie uderzania na worek po upływie piętnastu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności czterdzieści pięć sekund.", 13, "Seria na worek 15 sekund", 18, 15 },
                    { 65, "Szybkie serie uderzania na worek po upływie dziesięciu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności pięćdziesiąt sekund.", 13, "Seria na worek 10 sekund", 24, 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 65);
        }
    }
}

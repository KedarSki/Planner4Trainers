using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class NewExercise_for_WarmupTraining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExerciseTypeName",
                table: "WarmupOnPlace",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "WarmupOnPlace",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "ExerciseTypeName", "Name", "TimeLength" },
                values: new object[] { 8, "Z pozycji stojącej dynamiczne zejście do przysiadu. Następnie wyrzut nóg do tyłu przechodząc szybko do podporu przodem.", 3, null, "Wyrzuty nóg do tyłu", 0.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WarmupOnPlace",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "ExerciseTypeName",
                table: "WarmupOnPlace");
        }
    }
}

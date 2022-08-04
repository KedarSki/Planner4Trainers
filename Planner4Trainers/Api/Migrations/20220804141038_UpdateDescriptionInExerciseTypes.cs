using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class UpdateDescriptionInExerciseTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ExerciseType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. Ma ona szczególne znaczenie w zapobieganiu urazom. Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu.");

            migrationBuilder.UpdateData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Przejście do marszu ma na celu uspokojenie i wyrównanie oddechu z jednoczesnym dogrzaniem konkretnych partii mięśni oraz stawów.Partię mięśni oraz stawów, które będą brały główny udział w treningu.");

            migrationBuilder.UpdateData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Rozgrzewka miejscu na na celu dodatkową aktywację układu nerwowego ze względu na charakterystykę treningu bokserskiego. Trening bokserski wiąże się z ciągłąd zmianą dynamiki a zatem częstej zmiany tętna. Przygotowanie do tego ma nam dać właśnie rozgrzewka w miejscu,która zawiera ćwiczenia dynamiczne.");

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Luźny bieg z jednoczesnymi wymachami ramion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ExerciseType");

            migrationBuilder.UpdateData(
                table: "WarmupOnGo",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. Ma ona szczególne znaczenie w zapobieganiu urazom. Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu.");
        }
    }
}

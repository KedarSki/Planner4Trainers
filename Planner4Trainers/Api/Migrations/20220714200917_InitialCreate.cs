using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExerciseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarmupOnGo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarmupOnGo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarmupOnPlace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarmupOnPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarmupOnWalk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeLength = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarmupOnWalk", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExerciseType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Rozgrzewka w biegu" },
                    { 2, "Rozgrzewka w marszu" },
                    { 3, "Rozgrzewka w miejscu" }
                });

            migrationBuilder.InsertData(
                table: "WarmupOnGo",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 1, "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. Ma ona szczególne znaczenie w zapobieganiu urazom. Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu.", 1, "Bieg - Trucht", 10m },
                    { 2, "Ćwiczenie (Wykonujemy krążenia naprzemiennie oburącz) najpierw 15 sekund w przód a następnie 15 sekund w tył.", 1, "Krążenia ramion w przód oraz w tył - Naprzemiennie", 0.5m },
                    { 3, "Naprzemienne kolan w biegu do momentu osiągnięcia kątu prostego między udem a tłowiem.", 1, "Skip-A", 0.5m },
                    { 4, "Naprzemienne uderzanie piętami o pośladki.", 1, "Skip-C", 0.5m },
                    { 5, "Ćwiczenie wykonujemy w biegu lub podczas przeskoków nogami.", 1, "Krążenie ramion w przód oraz w tył - Jednocześnie", 0.5m },
                    { 6, "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarzą do środka sali.", 1, "Krok odstawno dostawny twarzą do środka sali.", 0.5m },
                    { 7, "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.", 1, "Krok odstawno dostawny twarzą na zewnątrz", 0.5m },
                    { 8, "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.", 1, "Krok odstawno dostawny twarzą na zewnątrz", 0.5m },
                    { 9, "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.", 1, "Przeplatanka twarzą do środka sali", 0.5m },
                    { 10, "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.", 1, "Przeplatanka twarzą do środka sali", 0.5m }
                });

            migrationBuilder.InsertData(
                table: "WarmupOnPlace",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 1, "Skłony tłowia do ziemi na wyprostowanych w kolanach nogach w delikatnym rozkroku", 3, "Skłony tłowia do ziemi z wyprostem", 0.5m },
                    { 2, "Skłony na wyprostowanych nogach w delikatnym rozkroku, ręce w pełnym wyproście na bok i dotykamy lewą rękę do prawej nogii odwrotnie.", 3, "Skręty tłowia do kostek", 0.5m },
                    { 3, "Skręty tłowia podczas wykonywania tłów należy pochylić do skłonu w przód a następnie odchylając w tył.", 3, "Skręty tłowia w przód i w tył", 0.5m },
                    { 4, "W delikatnym rozkroku wykonać dynamiczny cios sierpowy i po każdym ciosie wykonać skłon do kostki przeciwnej do ręki.Ilość powtórzeń 5 na stronę lub 30 sekund.", 3, "Cios sierpowy ze skłonem do kostki", 0.5m },
                    { 5, "Przysiady na złączonych nogach. Ilość powtórzeń ciągłych przez 30 sekund lub 15 powtórzeń.", 3, "Przysiady", 0.5m },
                    { 6, "Podpór przodem przy którym podnosimy i opuszczamy ciężąr ciałą. Ilość powtórzeń wykonujemy przez 30 sekund lub 15 powtórzeń.", 3, "Pompki", 0.5m },
                    { 7, "Przysiady na złączonych nogach.", 3, "Przysiady", 0.5m }
                });

            migrationBuilder.InsertData(
                table: "WarmupOnWalk",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 1, "Zwykły marsz w celu delikatnego uspokojena oddechu.", 2, "Marsz", 0.5m },
                    { 2, "Wymachy ramion w przeciwnym kierunku do nóg - Ręka musi być wyprostowana w stawie łokciowym.", 2, "Wymachy ramion góra-dół", 0.5m },
                    { 3, "Wymachy ramion na przemianstronnie w przeciwnym kierunku do nóg. Wymach ten wymaga jednej ręki wyprostowanej na bok a drugiej zgiętej w łokciu.", 2, "Wymachy ramion na bogi z wykrokiem", 0.5m },
                    { 4, "Cios prosty wykonany na pełnym wyproście w stawie łokciowym. Z lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku.Cios w przeciwnym kierunku do kroku.", 2, "Ciosy proste w marszu", 0.5m },
                    { 5, "Cios sierpowy wykonany ze skrętem oraz lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku.Cios w przeciwnym kierunku do kroku.", 2, "Ciosy sierpowe w marszu", 0.5m },
                    { 6, "Cios podbródkowy wykonany z lekkim przeniesieniem ciężaru ciała oraz lekko zgiętym tłowiem (pozycja bokserska)Cios w przeciwnym kierunku do kroku.", 2, "Ciosy podbródkowe w marszu", 0.5m },
                    { 7, "Wymach wyprostowanej ręki w łokciu do przeciwnej wyprostowanej w kolanie nogi.", 2, "Wymachy wyprostowanych ramion do wyprostowanej nogi", 0.5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseType");

            migrationBuilder.DropTable(
                name: "WarmupOnGo");

            migrationBuilder.DropTable(
                name: "WarmupOnPlace");

            migrationBuilder.DropTable(
                name: "WarmupOnWalk");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    public partial class AddAllDatabaseExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descirption",
                table: "Strength");

            migrationBuilder.DropColumn(
                name: "Descirption",
                table: "Speed");

            migrationBuilder.DropColumn(
                name: "Exercise",
                table: "Speed");

            migrationBuilder.RenameColumn(
                name: "Descirption",
                table: "Technique",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Exercise",
                table: "Strength",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "Speed",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseTypeId",
                table: "Technique",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseTypeId",
                table: "Strength",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseTypeId",
                table: "Speed",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rounds",
                table: "Speed",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Finals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeLength = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExerciseType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 11, "Wytrzymałość to zdolność organizmu do wykonywania wysiłku fizycznego przez długi czas, bez uszczerbku dla jego funkcji życiowych. To umiejętność zminimalizowania zmęczenia nabywana w czasie treningu. Wytrzymałość szybkościowa to umiejętność wykonywania szybkich ruchów na niezmiennym poziomie, np. w trakcie walki. Wytrzymałość jest fundamentem działań boksera pozwalającym mu na wykorzystanie wszystkich środków technicznych przez cały czas trwania walki. Jest ona tym ważniejsza, im dłużej trwa wysiłek fizyczny.\n Dobrą metodą trenowania wytrzymałości szybkościowej jest trening obwodowy. Liczba stacji powinna zawierać się w liczbie od 8 do 12", "Trening Wytrzymałościowy - Wytrzymałość szybkościowa" },
                    { 12, "Przygotowanie techniczne – proces opanowywania takiego zasobu zadań ruchowych (techniki działań), który w połączeniu z cechami budowy ciała, sprawności itp. pozwala uzyskiwać racjonalne i efektywnie najlepsze wyniki sportowe w sposób zgodny z przepisami obowiązującymi w danej dyscyplinie. \nDobra technika powinna charakteryzować się:\n- przyjęciem jednoznacznego celu ruchu;\n- dobrze zaznaczonym przedziałem czasowo - przestrzennym(faza przygotowawcza, główna i końcowa ruchu) \n- poprawnie wyrażonym przedziałem dynamiczno - czasowym(rytm, płynna kolejność napięć i rozluźnień)\n- wysoką elastycznością(umiejętne pokonywanie i wykorzystanie oporów środowiska)\n- wczesnym przewidywaniem ruchu(właściwe ustawienie koncepcji ruchu)\n- przewidywaniem ruchów obcych(przeciwnik, wiatr, śliska nawierzchnia itp.)\n WAŻNE: Trening techniki sportowej powinien zostać wykonany w parze z partnerem, który jest dobrany wzrostowo oraz wagowolub na tarczy u trenera. Podana technika w aplikacji jest techniką przykładową i oczywiście może ona być stosowana wymiennie w zależności od koncepcji trenerskiejkoncpecji treningu nadaną przez trenera.", "Technika sportowa – sposób wykonania zadania ruchowego" },
                    { 13, "Przygotowanie szybkościowe jest stosowane w okresie bezpośrednio przed startowym. W tym wypadku należy trenować szybkość ostatni tydzień przed startem. Szybkie wydolnościowe serie na worku od kilkudziesięciu do kilku sekund na 'rundę'. ", "Trening Szybkościowo-wytrzymałościowy" },
                    { 14, "Ćwiczenia końcowe są już elementem uspokojenia pracy krążenia. Są one nadal wykonywane dokładnie natomiast już z innym natężeniem. ", "Ćwiczenia końcowe" }
                });

            migrationBuilder.InsertData(
                table: "Finals",
                columns: new[] { "Id", "Description", "Exercise", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 62, "Jedno z ćwiczeń końcowych jest oczywiście skok na skakance. Skoki wykonujemy przez całę 3 minuty.", null, 14, "Skakanka", 3 },
                    { 63, "Walka z cienie. Długie dokładnie ruchy ", null, 14, "Walka z cieniem", 3 },
                    { 64, "Brzuszki lub inne ćwiczenia na mięśnie brzucha. Łącznie 120 powtórzeń lub więcej", null, 14, "Ćwiczenia na brzuch", 120 }
                });

            migrationBuilder.InsertData(
                table: "Speed",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "Rounds", "TimeLength" },
                values: new object[,]
                {
                    { 58, "Szybkie serie uderzania na worek po upływie trzydziestu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać 12. Przerwa to również trzydzieści sekund", 13, "Seria na worek 30 sekund", 12, 30 },
                    { 59, "Szybkie serie uderzania na worek po upływie dwudziesty sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać szesnaście. Przerwa powinna wyności czterdzieści sekund.", 13, "Seria na worek 20 sekund", 16, 20 },
                    { 60, "Szybkie serie uderzania na worek po upływie piętnastu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności czterdzieści pięć sekund.", 13, "Seria na worek 15 sekund", 18, 15 },
                    { 61, "Szybkie serie uderzania na worek po upływie dziesięciu sekund następuje zmiana zawodnika. Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności pięćdziesiąt sekund.", 13, "Seria na worek 10 sekund", 24, 10 }
                });

            migrationBuilder.InsertData(
                table: "Strength",
                columns: new[] { "Id", "Description", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 35, "Skakanka musi zostać dobrana tak aby ćwiczenie było wykonywane swobodnie dla trenującego", 11, "SKOKI NA SKAKANCE", 3 },
                    { 36, "Dynamiczne przysiady z obciążeniem. Przysiady mogą być uzupełnione o wspięcie na palce lub o dodatkowy wyskokna prostych nogach\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego. Jeżeli zawodnik jest bardzo młody można zastosowaćprzysiad bez obciążenia (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "PRZYSIADY Z OBCIĄŻENIEM (CIĘŻAR DO 10KG)", 3 },
                    { 37, "Dynamiczne ciosy z wyrzutem piłki lekarskiej w stronę partnera. Ciosy proste, sierpowe oraz z dołu.\n WAŻNE: Bardzo ważne, aby ciężar piłki został dobrany do wieku oraz predyspozycji trenującego. Partner również powinien zostać dobranymniej więcej wagowo i wzrostowo (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "RZUT PIŁKĄ LEKARSKĄ", 3 },
                    { 38, "Dynamiczne ciosy trzymając hantle. Ciosy proste, sierpowe oraz z dołu.\n WAŻNE: Bardzo ważne, aby ciężar hantli (do 5kg.) został dobrany do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "ĆWICZENIA Z HANTLAMI", 3 },
                    { 39, "Dynamiczne ciosy trzymając hantle. Ciosy proste, sierpowe.\n WAŻNE: Bardzo ważne, aby ciężarki (do 2kg.) zostały dobrane do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "ĆWICZENIA Z CIĘŻARKAMI", 3 },
                    { 40, "Dynamiczny bieg bokserski - ciosy z wyrzutem ciężarków.\n WAŻNE: Bardzo ważne, aby ciężarki (do 2kg.) zostały dobrane do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "BIEG BOKSERSKI Z CIĘŻARKAMI", 3 },
                    { 41, "Dynamiczna walka z cieniem - ciosy z wyrzutem ciężarków.\n WAŻNE: Bardzo ważne, aby ciężarki (do 1,5kg.) zostały dobrane do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "WALKA Z CIENIEM Z CIĘŻARKAMI", 3 },
                    { 42, "Dowolne ćwiczenie na mięśnie brzucha (preferowane skłony do lekko zgiętych nóg).Dodatkowo można dołożyć obciążenie w formie krążka do sztangi.\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "BRZUSZKI", 3 },
                    { 43, "Dynamiczne pompki przez całe 3 minuty. Zamiast pompek ćwiczenie można zastąpić np dynamicznym wyrzutem krążka lub sztangi (Do 15kg) stojąc na lekkougiętych nogach, ", 11, "POMPKI", 3 },
                    { 44, "Dynamiczne podciąganie nachwytem na drążku. Pamiętajmy, że trzy minuty podciągania to mimo wszystko dość długo. W takim wypadku jeżeli zawodniknie może podciągać się na drążku przez trzy minuty bez przerwy powinien wykonywać ćwiczenie aż do całkowitego zmęczenia mięśniowego, następnie po przerwie około 30 sekundpowinien natychmiast powrócić do ćwiczenia aby następnie znów wykonać je aż do kompletnego zmęczenia mięśni.", 11, "PODCIĄGANIE NA DRĄŻKU (NACHWYTEM)", 3 },
                    { 45, "Krążenia krążka o wadzę do 15kg. Krążenie ciała powinno zostać wykonane w pozycji stabilnej na lekko ugiętych nogachtak aby nieodrywać stóp od podłoża. Celem takiego ćwiczenia jest wyizolowanie  \n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "MACHANIE CIĘŻAREM PO OKRĘGU W JEDNĄ A POTEM W DRUGĄ STRONĘ (CIĘŻAR DO 15KG.)", 3 },
                    { 46, "Krążenia krążka o wadzę do 15kg. Krążenie ciała powinno zostać wykonane w pozycji stabilnej na lekko ugiętych nogachtak aby nieodrywać stóp od podłoża. Celem takiego ćwiczenia jest wyizolowanie  \n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego. (Obciążenie powinien dobierać wykwalifikowany trener)", 11, "MACHANIE CIĘŻAREM PO OKRĘGU W JEDNĄ A POTEM W DRUGĄ STRONĘ (CIĘŻAR DO 15KG.)", 3 }
                });

            migrationBuilder.InsertData(
                table: "Technique",
                columns: new[] { "Id", "Description", "Exercise", "ExerciseTypeId", "Name", "TimeLength" },
                values: new object[,]
                {
                    { 47, "Podstawa zarówno Polskiego jak i światowego dobrego boksu. Lewy cios prosty powinien zostać wykonany z zachowaniem zasad wykonania prawidłowego ciosu a więc zachować prawidłowy skręt bioder w celu przedłużenia ciosu.\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY PROSTY", 3 },
                    { 48, "Bezpośredni prawy cios prosty\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "PRAWY PROSTY", 3 },
                    { 49, "Ciosy proste w kombinacji dwóch ciosów prostych.\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub/i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY + PRAWY PROSTY", 3 },
                    { 50, "Ciosy proste w kombinacji trzech ciosów prostych.\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY - LEWY PROSTY", 3 },
                    { 51, "Kombinacja ciosów prostych i lewego ciosu sierpowego\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY - LEWY SIERP", 3 },
                    { 52, "Kombinacja ciosów prostych i prawego ciosu sierpowego\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY - UNIK - PRAWY SIERP", 3 },
                    { 53, "Kombinacja ciosów prostych i lewego ciosu z dołu\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY - UNIK - LEWY Z DOŁU", 3 },
                    { 54, "Kombinacja ciosów prostych i prawego ciosu z dołu\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY - UNIK - PRAWY Z DOŁU", 3 },
                    { 55, "Kombinacja ciosów z dołu i lewego ciosu sierpowego\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY Z DOŁU - LEWY SIERP", 3 },
                    { 56, "Kombinacja ciosów z dołu i prawego ciosu sierpowego\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY Z DOŁU - UNIK - PRAWY SIERP", 3 },
                    { 57, "Kombinacja ciosów z dołu i sierpowych\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji", null, 12, "LEWY - PRAWY Z DOŁU - UNIK - PRAWY SIERP - LEWY SIERP", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Finals");

            migrationBuilder.DeleteData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExerciseType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Speed",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Strength",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Technique",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DropColumn(
                name: "ExerciseTypeId",
                table: "Speed");

            migrationBuilder.DropColumn(
                name: "Rounds",
                table: "Speed");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Technique",
                newName: "Descirption");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Strength",
                newName: "Exercise");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Speed",
                newName: "ExerciseId");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeId",
                table: "Technique",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseTypeId",
                table: "Strength",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Descirption",
                table: "Strength",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descirption",
                table: "Speed",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Exercise",
                table: "Speed",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

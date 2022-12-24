using Api.Entities;
using Api.Entities.Plans;
using Api.Entities.Planners;
using Api.Entities.Trainings;
using Api.Entities.Trainings.Finals;
using Api.Entities.Trainings.Mains;
using Api.Entities.Trainings.Warmups;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Planner4TrainersDbContext:DbContext
    {
       public Planner4TrainersDbContext(DbContextOptions<Planner4TrainersDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Warmups exercises

            //Warmup while runnig

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 1,
                Name = "Bieg - Trucht",
                Description = "Luźny bieg z jednoczesnymi wymachami ramion",
                TimeLength = 90,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 2,
                Name = "Krążenia ramion w przód oraz w tył - Naprzemiennie",
                Description = "Ćwiczenie (Wykonujemy krążenia naprzemiennie oburącz) najpierw 15 sekund w przód a następnie 15 sekund w tył.",
                TimeLength = 30,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 3,
                Name = "Skip-A",
                Description = "Naprzemienne kolan w biegu do momentu osiągnięcia kątu prostego między udem a tłowiem.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 4,
                Name = "Skip-C",
                Description = "Naprzemienne uderzanie piętami o pośladki.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 5,
                Name = "Krążenie ramion w przód oraz w tył - Jednocześnie",
                Description = "Ćwiczenie wykonujemy w biegu lub podczas przeskoków nogami.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 6,
                Name = "Krok odstawno dostawny twarzą do środka sali.",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarzą do środka sali.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 7,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 8,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });


            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 9,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 10,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 30,
                ExerciseTypeId = 1
            });


            // Warmup while walking

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 1,
                Name = "Marsz",
                Description = "Zwykły marsz w celu delikatnego uspokojena oddechu.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 2,
                Name = "Wymachy ramion góra-dół",
                Description = "Wymachy ramion w przeciwnym kierunku do nóg - Ręka musi być wyprostowana w stawie łokciowym.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 3,
                Name = "Wymachy ramion na bogi z wykrokiem",
                Description = "Wymachy ramion na przemianstronnie w przeciwnym kierunku do nóg. Wymach ten wymaga jednej ręki wyprostowanej na bok a drugiej zgiętej w łokciu.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 4,
                Name = "Ciosy proste w marszu",
                Description = "Cios prosty wykonany na pełnym wyproście w stawie łokciowym. Z lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 5,
                Name = "Ciosy sierpowe w marszu",
                Description = "Cios sierpowy wykonany ze skrętem oraz lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 6,
                Name = "Ciosy podbródkowe w marszu",
                Description = "Cios podbródkowy wykonany z lekkim przeniesieniem ciężaru ciała oraz lekko zgiętym tłowiem (pozycja bokserska)" +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 7,
                Name = "Wymachy wyprostowanych ramion do wyprostowanej nogi",
                Description = "Wymach wyprostowanej ręki w łokciu do przeciwnej wyprostowanej w kolanie nogi.",
                TimeLength = 30,
                ExerciseTypeId = 2
            });

            //Warmup while standing.

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 1,
                Name = "Skłony tłowia do ziemi z wyprostem",
                Description = "Skłony tłowia do ziemi na wyprostowanych w kolanach nogach w delikatnym rozkroku",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 2,
                Name = "Skręty tłowia do kostek",
                Description = "Skłony na wyprostowanych nogach w delikatnym rozkroku, ręce w pełnym wyproście na bok i dotykamy lewą rękę do prawej nogi" +
                "i odwrotnie.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 3,
                Name = "Skręty tłowia w przód i w tył",
                Description = "Skręty tłowia podczas wykonywania tłów należy pochylić do skłonu w przód a następnie odchylając w tył.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 4,
                Name = "Cios sierpowy ze skłonem do kostki",
                Description = "W delikatnym rozkroku wykonać dynamiczny cios sierpowy i po każdym ciosie wykonać skłon do kostki przeciwnej do ręki." +
                "Ilość powtórzeń 5 na stronę lub 30 sekund.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });


            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 5,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach. Ilość powtórzeń ciągłych przez 30 sekund lub 15 powtórzeń.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 6,
                Name = "Pompki",
                Description = "Podpór przodem przy którym podnosimy i opuszczamy ciężąr ciałą. Ilość powtórzeń wykonujemy przez 30 sekund " +
                "lub 15 powtórzeń.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 7,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 8,
                Name = "Wyrzuty nóg do tyłu",
                Description = "Z pozycji stojącej dynamiczne zejście do przysiadu. Następnie wyrzut nóg do tyłu przechodząc szybko do podporu przodem.",
                TimeLength = 30,
                ExerciseTypeId = 3
            });


            // Power training

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 1,
                Name = "WYCISKANIE SZTANGI W LEŻENIU NA ŁAWCE POZIOMEJ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu:" +
                " cała grupa mięśni klatki piersiowej, mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych." +
                "\nWykonanie: Kładziemy się na ławce tak, by nogi ugięte były pod kątem prostym i przylegały do podłoża. " +
                "Uchwyt średni(taki, by po opuszczeniu sztangi na klatkę ramiona tworzyły z przedramionami kąt prosty-kciuk dla bezpieczeństwa powinien obejmować" +
                " sztangę-choć wielu bardziej doświadczonych kulturystów preferuje raczej tzw. ”małpi chwyt” (kciuk ponad gryfem)." +
                "Opuszczamy sztangę na klatkę na wysokość ok.1 cm powyżej brodawek. Przy opuszczaniu sztangi " +
                "wykonujemy głęboki wdech-wydychamy powietrze w trakcie wyciskania. Można okresowo praktykować przytrzymywanie sztangi przez chwilę na klatce " +
                "przed wyciśnięciem.(szczególnie przydatne, jeżeli mamy w planach ewentualne starty w zawodach w wyciskaniu)-dodatkowo rozbudowuje " +
                "siłę-pobudza do dodatkowego wysiłku. Łokcie prowadzimy w trakcie całego ruchu po bokach-tak by nie „uciekały”do środka. " +
                "Ruch wyciskania kończymy(dla lepszego napięcia mięśni)zanim łokcie zostaną zblokowane. " +
                "Ćwiczenie to można wykonywać również na maszynach lub na suwnicy Smitha.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });


            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 2,
                Name = "WYCISKANIE SZTANGIELEK W LEŻENIU NA ŁAWCE POZIOMEJ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "cała grupa mięśni klatki piersiowej,mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych. " +
                "\nWYKONANIE: Podobnie jak w ćwiczeniu 1( ze sztangą)-daje ono jednak dodatkowe możliwości ćwiczącemu- np. chcąc położyć większy nacisk na rozwój wewnętrznej części klatki" +
                " można w górnym położeniu(podczas fazy wyciskania) zbliżać sztangielki do siebie, co nie jest możliwe przy użyciu sztangi. Również faza opuszczania może mieć " +
                "nieco odmienny przebieg - przy ćwiczeniu ze sztangą ruch ogranicza nam gryf sztangi, a wykorzystując do tego ćwiczenia sztangielki" +
                " możemy opuszczać ręce poniżej (głębiej) poziomu klatki, co dodatkowo rozciąga mięsnie( w myśl zasady: im większy zakres ruchu, tym pełniejszy rozwój mięśni.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 3,
                Name = "WYCISKANIE SZTANGI W LEŻENIU NA ŁAWCE SKOŚNEJ-GŁOWĄ  W GÓRĘ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "cała grupa mięsni klatki piersiowej z podkreśleniem jej górnej części, mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych" +
                "\nWYKONANIE: Ławkę ustawiamy pod kątem 30-45 stopni(większy kąt bardziej angażuje w ćwiczeniu mięśnie naramienne), " +
                "kładziemy się głową do góry. Uchwyt sztangi, oddychanie, prowadzenie łokci, jak w ćwiczeniu na ławce płaskiej." +
                "Chwytamy sztangę i opuszczamy ją na klatkę-ok.10 cm. poniżej szyi. Staramy się skupiać uwagę na angażowaniu w pracę tylko mięsni piersiowych i maksymalnym wyłączeniu z niej mięsni naramiennych." +
                " W tym celu można lekko wygiąć grzbiet," +
                " jednocześnie wypychając klatkę do przodu. Nie wolno jednak odrywać zbytnio pleców od ławki, a biodra muszą bezwzględnie przylegać do ławki. ",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 4,
                Name = "WYCISKANIE SZTANGIELEK W LEŻENIU NA ŁAWCE SKOŚNEJ-GŁOWĄ W GÓRĘ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "cała grupa mięsni piersiowych z podkreśleniem jej górnej części, mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych." +
                "\nWYKONANIE: ozycja jak w ćwiczeniu ze sztangą-dodatkowe możliwości jak w ćwiczeniu ze sztangielkami na ławce płaskiej.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 5,
                Name = "WYCISKANIE SZTANGI W LEŻENIU NA ŁAWCE SKOŚNEJ-GŁOWĄ W DÓŁ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar. Ważne aby zabezpieczyć się przed zsuwaniem dół podczas wykonywanego ćwiczenia." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "cała grupa mięsni piersiowych z podkreśleniem dolnych rejonów, mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych." +
                "\nWYKONANIE: Ławeczkę ustawiamy pod kątem 30-45 stopni- kładziemy się głową w dół, zapierając nogi o coś dla stabilności," +
                "(aby nie zsunąć się w dół podczas wykonywania ćwiczenia).Ruch wygląda tak samo, jak podczas wyciskania na ławce poziomej. " +
                "Opuszczając sztangę nabieramy głęboko powietrza, wydychamy je wyciskając sztangę w górę. " +
                "Ćwiczenie można wykonywać również przy pomocy suwnicy Smitha, lub maszyn.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 6,
                Name = "ROZPIĘTKI ZE SZTANGIELKAMI W LEŻENIU NA ŁAWCE POZIOMEJ.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "mięsień piersiowy większy(jego wewnętrzna i zewnętrzna część),mięsień kruczoramienny, przednie aktony mięśni naramiennych, " +
                "piersiowy mniejszy, zębaty przedni" +
                "\nWykonanie: Ćwiczenie rozpoczynamy z ramionami wyprostowanymi-prostopadłymi do podłoża( palce dłoni skierowane są do siebie), " +
                "a w trakcie ruchu lekko uginamy je w łokciach. Nabieramy powietrza, gdy sztangielki są u góry(na początku ruchu) wydychamy je, " +
                "gdy sztangielki wędrują do góry. W końcowej fazie ruch można zatrzymać na chwilę w celu lepszego napięcia mięśni." +
                " Staramy się nie uderzać sztangielkami o siebie, ale zatrzymywać ruch zanim się zetkną." +
                " Ważne jest wykonywanie pełnego zakresu ruchu(by dostatecznie rozciągnąć mięśnie)-im większy zakres wykonanego ruchu, tym pełniejszy ogólny rozwój mięśnia. " +
                "Obciążenia dostosowujemy takie, by  wykonywać ćwiczenie poprawnie technicznie. " +
                "Ćwiczenie to można również wykonywać przy pomocy linek wyciągów,lub specjalnej maszyny",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 7,
                Name = "ROZPIĘTKI ZE SZTANGIELKAMI W LEŻENIU NA ŁAWCE SKOŚNEJ - GŁOWĄ DO GÓRY.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "\nGłówne mięśnie zaangażowane w ćwiczeniu: " +
                "mięsień piersiowy większy(jego wewnętrzna i zewnętrzna część),mięsień kruczoramienny, przednie aktony mięśni naramiennych, " +
                "piersiowy mniejszy, zębaty przedni" +
                "\nWykonanie: Ławeczkę ustawiamy pod kątem 30-45 stopni, ćwiczenie rozpoczynamy z ramionami wyprostowanymi-prostopadłymi do podłoża( palce dłoni skierowane są do siebie), a w trakcie ruchu lekko uginamy je w łokciach." +
                " Nabieramy powietrza, gdy sztangielki są u góry(na początku ruchu) wydychamy je, gdy sztangielki wędrują do góry."+
                "Ważne jest wykonywanie pełnego zakresu ruchu(by dostatecznie rozciągnąć mięśnie) - im większy zakres wykonanego ruchu, " +
                "tym pełniejszy ogólny rozwój mięśnia.Obciążenia dostosowujemy takie,"+
                "by wykonywać ćwiczenie poprawnie technicznie.Ćwiczenie również można wykonywać zastępując sztangielki rączkami wyciągów.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 8,
                Name = "POMPKI NA PORĘCZACH",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: cała grupa mięśni klatki piersiowej, przednie aktony mięśni naramiennych, mięśnie trójgłowe ramion " +
                "\nWykonanie: W tym ćwiczeniu, podobnie jak przy wyciskaniu wąsko również ważne jest by pracę wykonywały w głównym stopniu mięśnie piersiowe, w mniejszym stopniu chodzi nam o pracę mięśni trójgłowych ramion. " +
                "Elementem decydującym o większym zaangażowaniu jednych, bądź drugich mięśni jest pozycja tułowia i ułożenie łokci. " +
                "Należy wypracować takie ułożenie tułowia, przy którym główną pracę będą wykonywały mięśnie piersiowe, a łokcie pracować powinny w pewnym oddaleniu od tułowia. " +
                "Dla lepszego wyeliminowania pracy tricepsów i lepszego napięcia mięsni piersiowych można również nie prostować ramion do końca. ",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 5
            });


            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 9,
                Name = "PODCIĄGANIE NA DRĄŻKU SZEROKIM UCHWYTEM (NACHWYT).",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie najszersze grzbietu, obłe mniejsze, obłe większe, podgrzebieniowe, dwugłowe ramion." +
                "\nWykonanie:Nie ma drugiego takiego ćwiczenia pod względem wszechstronności rozwoju mięsni grzbietu. Ćwiczenie to można wykonywać do karku i do brody, lecz wersja do karku jest mniej naturalna dla stawów. " +
                "Chwytamy drążek nachwytem na szerokość taką, by po podciągnięciu ramiona z przedramionami tworzyły kąt prosty(w przybliżeniu).Nogi ugięte w kolanach(dla lepszej stabilności można je spleść)." +
                "Łokcie pracują w płaszczyźnie pleców-w jednej linii. Wdech robimy przed rozpoczęciem ruchu podciągania-wydech dopiero, gdy jesteśmy już u góry." +
                " Ruch podciągania kończymy w momencie, gdy nasza broda(lub kark) jest na wysokości drążka lub nieco ponad nim. Opuszczamy się wolno i pod pełną kontrolą." +
                " Jeśli jesteśmy bardziej zaawansowani i możemy wykonać wiele powtórzeń w tym ćwiczeniu, to można zastosować dodatkowe obciążenie. ",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 10,
                Name = "PODCIĄGANIE NA DRĄŻKU W UCHWYCIE NEUTRALNYM.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie obłe mniejsze, obłe większe, podgrzebieniowe, najszersze grzbietu, dwugłowe ramion." +
                "\nWykonanie:Chwytamy specjalny uchwyt(może to być rączka trójkątna od wyciągu przerzucona nad drążkiem prostym)-dłonie równolegle do siebie w odległości ok.20-25cm.,palcami skierowane do siebie." +
                " Z pełnego zwisu podciągamy się do linii podmostkowej." +
                " Nogi zwisają luźno, lekko podkurczone w kolanach. Łokcie staramy się prowadzić wzdłuż tułowia. Opuszczamy się powoli-kontrolując swój ciężar. " +
                "Jeśli jesteśmy bardziej zaawansowani i możemy wykonać wiele powtórzeń w tym ćwiczeniu, to można zastosować dodatkowe obciążenie. ",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });


            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 11,
                Name = "PODCIĄGANIE NA DRĄŻKU PODCHWYTEM.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: najszersze grzbietu, obłe mniejsze, obłe większe, podgrzebieniowe, dwugłowe ramion." +
                "\nWykonanie:Chwytamy drążek prosty podchwytem. Nogi zwisają luźno, lekko podkurczone w kolanach. Ze zwisu przechodzimy do podciągania." +
                " Kończymy je, gdy nasza broda znajdzie się ponad drążkiem, a nasze ramiona będą w pełni ugięte w łokciach. Łokcie staramy się prowadzić wzdłuż tułowia. " +
                "Opuszczamy się powoli-kontrolując swój ciężar. " +
                "Jeśli jesteśmy bardziej zaawansowani i możemy wykonać wiele powtórzeń w tym ćwiczeniu, to można zastosować dodatkowe obciążenie.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });


            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 12,
                Name = "PODCIĄGANIE SZTANGI W OPADZIE(WIOSŁOWANIE).",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: najszersze grzbietu, obłe mniejsze, obłe większe, podgrzebieniowe, czworoboczne, mięśnie równoległoboczne" +
                "\nWykonanie:Stajemy nad sztangą w rozkroku na szerokość barków, pochylamy tułów do pozycji prawie równoległej do podłoża, plecy w dolnym odcinku mocno ugięte do środka," +
                " nogi lekko ugięte w kolanach przez cały czas trwania ćwiczenia. " +
                "Wdech bierzemy w momencie rozpoczęcia podciągania-wydech dopiero, gdy sztanga dochodzi do brzucha(lub do klatki). " +
                "Sztangę chwytamy na szerokość nieco większą od barków i podciągamy ją do brzucha(łokcie prowadzimy na boki)." +
                "\nDruga wersja zakłada podciąganie sztangi do klatki piersiowej(jest to ruch odwrotny do wyciskania sztangi na ławce" +
                "-angażowane są mocniej w tej wersji mięśnie czworoboczne grzbietu, obłe większe, mniejsze i tylne aktony mięśni naramiennych. " +
                "Ćwiczenie to można również wykonywać przy pomocy suwnicy Smitha. Opuszczamy ciężar z pełną kontrolą, wolnym tempem. " +
                "Jeszcze inna wersja zakłada zastosowanie w tym ćwiczeniu podchwytu(można zastosować wtedy, dla lepszych efektów sztangę łamaną)." +
                "Ta wersja z kolei mocniej angażuje dolne rejony ćwiczonych mięśni.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 13,
                Name = "PODCIĄGANIE SZTANGIELKI W OPADZIE(WIOSŁOWANIE).",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie najszersze grzbietu, obłe mniejsze, obłe większe, mięśnie równoległoboczne" +
                "\nWykonanie:Typowo izolowane ćwiczenie na rozbudowę(szczególnie na „grubość” górnej i środkowej części)mięśni najszerszych. Wolną ręką opieramy się o coś stabilnego(może to być nasze kolano, ale lepsza do tego będzie ławka).Tułów w pozycji prawie równoległej do podłogi. W drugą rękę chwytamy sztangielkę-i tutaj dwie wersje ćwiczenia-" +
                "\n1:chwyt przez cały czas trwania ćwiczenia równoległy-dłoń zwrócona palcami w kierunku ciała, łokieć pracuje wzdłuż tułowia-pracują mocniej górne i środkowe części mięsni najszerszych;" +
                "\n2: chwyt prostopadły do tułowia, dłoń zwrócona kciukiem w kierunku ciała, łokieć pracuje w bok od tułowia(pod kątem 90 stopni)-pracują mocniej górne części mięsni najszerszych." +
                " Podciąganie kończymy, gdy gryf sztangielki znajdzie się na równi z naszym barkiem lub odrobinę wyżej." +
                " Opuszczanie ciężaru kontrolowane.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 14,
                Name = "PODCIĄGANIE KOŃCA SZTANGI W OPADZIE.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: najszersze grzbietu, obłe mniejsze, obłe większe, podgrzebieniowe, czworoboczne, mięśnie równoległoboczne" +
                "\nWykonanie:Stajemy okrakiem nad gryfem sztangi(półsztangi)i chwytamy drążek, tułów z udami tworzą kąt prosty, a z podłogą nieco większy. Nogi lekko ugięte w kolanach. W takiej pozycji podciągamy sztangę do brzucha. " +
                "Opuszczanie ciężaru kontrolowane. Wdech bierzemy w momencie rozpoczęcia podciągania-wydech dopiero, gdy sztanga dochodzi do brzucha. W zależności od kąta, pod jakim chcemy zaatakować mięśnie używamy w tym ćwiczeniu różnych drążków(chwytamy je różnym uchwytem). " +
                "I tak np. może to być drążek sztangi typu „T” mocniej zaangażowane górne części mięsni najszerszych i mięśni obłych-łokcie prowadzimy w bok od tułowia.)lub drążek/rączka równoległa łokcie prowadzone wzdłuż tułowia-mocniej zaangażowane środkowe części mięsni najszerszych i obłych). " +
                "Możne też ćwiczenie to wykonywać w leżeniu na ławce skośnej(mniej angażuje mięśnie dolnego odcinka grzbietu, mocniej izoluje mięśnie najszersze.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });


            modelBuilder.Entity<Power>().HasData(new Power
            {

                Id = 15,
                Name = "PRZYCIĄGANIE LINKI WYCIĄGU DOLNEGO W SIADZIE PŁASKIM.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: najszersze grzbietu, obłe mniejsze, obłe większe, podgrzebieniowe, czworoboczne, mięśnie równoległoboczne" +
                "\nWykonanie:Stajemy okrakiem nad gryfem sztangi(półsztangi)i chwytamy drążek, tułów z udami tworzą kąt prosty, a z podłogą nieco większy. Nogi lekko ugięte w kolanach. W takiej pozycji podciągamy sztangę do brzucha. " +
                "Opuszczanie ciężaru kontrolowane. Wdech bierzemy w momencie rozpoczęcia podciągania-wydech dopiero, gdy sztanga dochodzi do brzucha. W zależności od kąta, pod jakim chcemy zaatakować mięśnie używamy w tym ćwiczeniu różnych drążków(chwytamy je różnym uchwytem). " +
                "I tak np. może to być drążek sztangi typu „T” mocniej zaangażowane górne części mięsni najszerszych i mięśni obłych-łokcie prowadzimy w bok od tułowia.)lub drążek/rączka równoległa łokcie prowadzone wzdłuż tułowia-mocniej zaangażowane środkowe części mięsni najszerszych i obłych). " +
                "Możne też ćwiczenie to wykonywać w leżeniu na ławce skośnej(mniej angażuje mięśnie dolnego odcinka grzbietu, mocniej izoluje mięśnie najszersze.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6
            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 16,
                Name = "PODCIĄGANIE (WIOSŁOWANIE) W LEŻENIU NA ŁAWECZCE POZIOMEJ.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie najszersze grzbietu, obłe mniejsze, obłe większe" +
                "\nWykonanie: Jest to ćwiczenie podobne do wiosłowania w opadzie tułowia, ale odciąża ono dolny odcinek mięsni grzbietu-szczególnie polecane dla osób, które mają kłopoty z tą właśnie częścią." +
                " Technika podobna jak w ćwiczeniu w opadzie. Tułów oparty o ławkę poziomą. Łokcie przy ćwiczeniu ze sztangą prowadzimy w bok od tułowia, " +
                "a w wersji ze sztangielkami wzdłuż tułowia(zaangażowanie mięśni analogicznie, jak przy ćwiczeniu w opadzie-z wyłączeniem pracy dolnego odcinka grzbietu). " +
                "Ćwiczenie to można również wykonać na ławce skośnej. Zaangażowane będą te same mięsnie jednak pod innym kątem.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 6

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 17,
                Name = "PRZYSIADY ZE SZTANGĄ NA BARKACH",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: pracują przede wszystkim głowy boczne, poś#286acanie i przyśrodkowe mięsni czworogłowych ud" +
                "\nWykonanie: Ćwiczenie to można wykonywać zarówno ze sztanga, jak i sztangielkami,przy pomocy suwnicy Smitha lub maszyny. Wchodzimy pod sztangę stojącą na stojakach, barki opuszczone i odwiedzione w tył, gryf sztangi dotyka naszego karku na mięśniach czworobocznych grzbietu(ich górnej części), dłonie rozstawione w wygodnej i stabilnej pozycji na gryfie, klatka wypchnięta ku przodowi, naturalna krzywizna kręgosłupa-dolny odcinek grzbietu wypchnięty do przodu, rozstaw stóp w zależności od naszego poczucia stabilności(zmiana rozstawu stóp powodować będzie atak na mięśnie pod innym kątem), najlepiej nieco szerzej, niż barki, całe stopy przylegają do podłogi, ciężar ma opierać się na piętach, głowa zadarta nieco do tyłu. " +
                "Z tej pozycji nabieramy głęboko powietrza i ściągamy sztangę ze stojaków i rozpoczynamy ruch w dół(najlepiej przed tym wypuszczając powietrze po ściąganiu sztangi ze stojaków i nabierając go ponownie). " +
                "Przez cały czas plecy wygięte w jednakowy sposób, pracują tylko nogi. Najlepiej, gdy przez cały czas biodra i pięty znajdują się w jednej linii, nie wypychamy kolan do przodu(nie powinny wysuwać się dalej niż końce palców stóp). Schodzimy w dół do momentu, gdy zanika kontrola pracy mięsni czworogłowych, a ich rozciągnięcie jest maksymalne. Rozpoczynamy powrót do pozycji wyjściowej, wypychając się piętami podnosimy się w gorę, jednocześnie wypychając biodra w przód, aż do pozycji startowej. " +
                "Drugą wersją tego ćwiczenia są tzw. ”półprzysiady” lub „płytkie” przysiady, można je wykonać również na suwnicy Smitha." +
                " Różnica polega na mniejszym zakresie ruchu-opuszczamy się jedynie do momentu, gdy nasze nogi ugną się pod kątem równym lub nieco mniejszym, niż 90 stopni.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 18,
                Name = "HACK-PRZYSIADY",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: wszystkie głowy mięsni czworogłowych ud" +
                "\nWykonanie: Ćwiczenie różni się od zwykłych przysiadów ułożeniem sztangi(z tyłu za plecami, pod pośladkami w wyprostowanych rękach)i, co za tym idzie bardziej pionową pozycją tułowia w trakcie wykonania ćwiczenia. " +
                "Ze względu na technikę wykonania i ułożenie sztangi ciężar, jaki użyjemy w tym ćwiczeniu będzie mniejszy, niż w zwykłych przysiadach. " +
                "Pozycja wyjściowa to wyprostowany tułów, klatka wypchnięta ku przodowi, nogi w rozkroku na szerokość barków, ramiona wyprostowane wzdłuż tułowia, w dłoniach gryf sztangi(trzymany za plecami). Z tej pozycji wykonujemy przysiad do momentu, gdy nasze nogi będą ugięte pod kątem 90 stopni lub nieco mniejszym." +
                " Jednocześnie wypychamy kolana nieco do przodu, nie odrywając jednak stóp od podłoża-ciężar wypychamy z pięt." +
                " Ćwiczenie można również wykonać przy pomocy suwnicy Smitha",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 19,
                Name = "PRZYSIADY WYKROCZNE",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: przywodziciele krótkie i wielkie, w mniejszym stopniu głowy boczne i przyśrodkowe mięsni czworogłowych ud" +
                "\nWykonanie: Pozycja wyjściowa taka, jak przy przysiadach zwykłych. Z tej pozycji stawiamy jedną noga krok do przodu(na tyle duży, by po wykonaniu przysiadu do momentu ugięcia nogi pod kątem 90 stopni-podudzia były prostopadle do podłogi, a uda równoległe), po czym wykonujemy na nodze wykrocznej przysiad, na tyle głęboki, by noga ugięła się pod kątem ok.90 stopni. " +
                "Po czy wracamy do pozycji wyjściowej i wykonujemy to samo, ale drugą nogą. " +
                "Noga nie ćwiczona w trakcie przysiadu lekko ugięta w kolanie, a w trakcie, gdy noga wykroczne jest wysunięta do przodu- czasowo przylega do podłogi tylko palcami(noga nie trenowana). " +
                "Wdech robimy w momencie stawiania kroku, wydech-w trakcie wstawania z przysiadu. " +
                "Do tego ćwiczenia można użyć zarówno sztangi(trzymanej na karku), jak i sztangielek(trzymanych w opuszczonych luźno obok tułowia rękach). " +
                "Istnieje również bardzo podobne(pod względem zaangażowania mięśni) ćwiczenie-„PRZYSIAD ROZDZIELNY”- polegające na wykonywaniu przysiadów na nodze wykrocznej w wykroku. " +
                "Wykonuje się kilka-kilkanaście przysiadów na jednej nodze, po czym zmienia się ćwiczoną nogę.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 20,
                Name = "WYSOKI STEP ZA SZTANGĄ/SZTANGIELKAMI.",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: Przywodziciele krótkie i wielkie, w mniejszym stopniu głowy boczne i przyśrodkowe mięsni czworogłowych ud" +
                "\nWykonanie: Do ćwiczenia potrzebna będzie, poza obciążeniem mocna i stabilna ławka(lub wysoki podest).Stajemy w lekkim rozkroku, nieco węższym, niż barki, przed ławka(podestem)- pozycja, jak do przysiadów." +
                " Jako ciężar stosujemy sztangę trzymaną na barkach z tyłu, lub sztangielki trzymane w dłoniach, opuszczone luźno obok tułowia. " +
                "Z tej pozycji wykonujemy wstępowanie na jednej nodze na ławkę, po czym dostawiamy drugą nogę i przez moment stoimy na ławce na wyprostowanych nogach i przy napiętych mięśniach. Powrotny ruch jest odwrotnością wstępowania-zstępowaniem." +
                " Powietrza nabieramy przed rozpoczęciem wstępowania na ławkę- wypuszczamy, gdy obie nogi znajdą się na ławce." +
                " Ważne jest, by każde powtórzenie zaczynać od innej nogi(raz lewą, raz prawą), gdyż właśnie noga, która wstępujemy na ławkę jako pierwszą, jest trenowana.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 21,
                Name = "PROSTOWNIE NÓG W SIADZIE",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: W zależności od ułożenia stóp zaangażowane różne głowy mięśni czworogłowych ud" +
                "\nWykonanie: siadamy na siodle maszyny(ławki), dobrze gdy mamy oparcie-zapewnia ono lepszą stabilność tułowia, dłońmi chwytamy za uchwyt(lub krawędź) maszyny. " +
                "Nogi ugięte w kolanach, zaparte o drążek maszyny na stopami(na wysokości kostek). " +
                "Z tej pozycji wykonujemy ruch prostowania nóg do pełnego wyprostu w stawach kolanowych. " +
                "W pozycji wyprostowanej zatrzymujemy ruch przez chwilę dla lepszego napięcia mięśni. Po czym powracamy do pozycji wyjściowej. " +
                "Powrót w tempie wolnym i pod pełną kontrolą ciężaru." +
                " Powietrze nabieramy przed rozpoczęciem prostowania, wypuszczamy je, gdy kończymy prostowanie nóg.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 22,
                Name = "UGINANIE NÓG W LEŻENIU",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie dwugłowe ud, mięśnie półścięgniste, mięśnie smukłe i mięśnie krawieckie." +
                "\nWykonanie: Ćwiczenie to wykonujemy na specjalnej maszynie,lub za pomocą wyciągu i specjalnym opasek na nogi. Kładziemy się na brzuchy tak, by poza ławkę wystawały jedynie podudzia poniżej kolan, nogi wyprostowane w kolanach, zaparte o drążek maszyny na wysokości ścięgien Achillesa(nad piętami), dłonie na uchwytach(lub krawędzi) maszyny." +
                " Z tej pozycji wykonujemy ruch maksymalnego uginania nóg w kolanach." +
                " W końcowym momencie uginania zatrzymujemy ruch przez chwilę dla lepszego napięcia mięśni. Po czym powracamy do pozycji wyjściowej." +
                " Powrót w tempie wolnym i pod pełną kontrolą ciężaru. " +
                "Biodra(jak i reszta tułowia) przez cały czas trwania ćwiczenia przylegają do powierzchni ławki. Powietrze nabieramy przed rozpoczęciem uginania, wypuszczamy je, gdy kończymy uginanie nóg. " +
                "Ćwiczenie to można wykonać również w pozycji stojąc(jednonóż)-na maszynie, lub wyciągu",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 23,
                Name = "WSPIECIA NA PALCE W STANIU",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: obie głowy mięsni brzuchatych łydek, mięśnie płaszczkowate i strzałkowe długie." +
                "\nWykonanie: Ćwiczenie to można wykonywać zarówno przy pomocy sztangi, suwnicy Smitha lub specjalnej maszyny. Można wykonywać je również bez obciążenia, a także jednonóż. " +
                "Sztangę można również zastąpić sztangielką trzymaną w dłoni(po tej samej stronie, co ćwiczona noga: lewa noga- lewa ręka, prawa noga- prawa ręka). " +
                "Istotnym elementem w tym ćwiczeniu jest użycie grubej podkładki pod palce stóp, która pozwala zwiększyć znacznie zakres ruchu, a co za tym idzie-poprawić efektywność ćwiczenia. " +
                "Pozycja wyjściowa, to wyprostowany tułów i plecy, nogi wyprostowane w kolanach, rozkrok 25-30 cm, palce stóp(wraz ze stawami łączącymi je ze śródstopiem) na podkładce-mięsnie łydek rozciągnięte maksymalnie. Z takiej pozycji rozpoczynamy wspięcia. " +
                "Ruch powinien być wolny i dokładny, ze stałym „czuciem” pracy mięśni. " +
                "Należy unikać odbijania się pięt od podłogi.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 7

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 24,
                Name = "WYCISKANIE SZTANGI SPRZED GŁOWY",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: przednie i boczne aktony mięsni naramiennych, mięśnie trójgłowe ramion." +
                "\nWykonanie: Ćwiczenie to można wykonywać zarówno w pozycji stojącej (tzw. żołnierskie wyciskanie) jak i siedzącej. " +
                "Do ćwiczenia można również użyć tzw. suwnicy Smitha ,lub maszyn",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 8

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 25,
                Name = "WYCISKANIE SZTANGI ZZA GŁOWY",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: przednie i boczne  aktony mięśni naramiennych,mięśnie trojgłowe ramion." +
                "\nWykonanie: ćwiczenie to, podobnie jak poprzednie można wykonywać zarówno w pozycji stojącej, jak i siedzącej. " +
                "Podobnie ,jak w ćwiczeniu poprzednim można użyć suwnicy Smitha lub maszyn.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 8

            });


            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 26,
                Name = "UNOSZENIE SZTANGIELEK BOKIEM W GÓRĘ",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: przednie i boczne  aktony mięśni naramiennych,mięśnie trojgłowe ramion." +
                "\nWykonanie: kolejne ćwiczenie, które można wykonywać zarówno w pozycji stojącej, jak i siedzącej" +
                "dłonie ze sztangielkami przez cały czas trzymamy tak," +
                "aby ich wewnętrzne części skierowane były do przodu(inna wersja przewiduje uchwyt młotkowy - dłonie zwrócone w czasie całego ruchu palcami w kierunku głowy).Ruch powinien odbywać się  pod pełną kontrolą ciężaru-ważna jest również pozycja podczas ćwiczenia - podobna do pozycji przy wyciskaniu sztangi. (wypchnięta klatka, naturalna krzywizna kręgosłupa)",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 8

            });
            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 27,
                Name = "UNOSZENIE SZTANGIELEK W OPADZIE TŁOWIA",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: jest to ćwiczenie na tylną część mięśni naramiennych," +
                "\nWykonanie: ćwiczenie wykonujemy w pozycji siedzącej lub stojącej -" +
                " W pozycji stojącej: tułów ustawiamy w położeniu zbliżonym do prostopadłego do podłoża i staramy się w trakcie ruchu nie wykonywać nim tzw. bujania-utrzymujemy możliwie sztywno. " +
                "Z pozycji wyjściowej ruchem kolistym unosimy sztangielki maksymalnie w górę, utrzymując przez cały czas ćwiczone mięśnie w stanie napięcia. " +
                "Staramy się, aby w ruchu powrotnym sztangielki poruszały się po tym samym torze. " +
                "Jak w poprzednim ćwiczeniu ,można w pozycji szczytowej przytrzymać przez chwilę sztangielki w celu dodatkowego napięcia mięśni",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 8

            });
            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 28,
                Name = "WYCISKANIE „FRANCUSKIE”SZTANGI W SIADZIE",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: głowy boczne i przyśrodkowe mięśni trójgłowych ramion" +
                "\nWykonanie: Ćwiczenie to rozwija wszystkie głowy tricepsów ze szczególnym wskazaniem na głowę długa." +
                " Można je wykonywać zarówno w pozycji stojącej, jak i siedzącej. W pozycji siedzącej ponadto można zastosować oparcie(np. na ławce skośnej). " +
                "Polepsza to stabilność, a co za tym idzie pozwala lepiej skoncentrować się na wykonaniu ćwiczenia. Możemy użyć sztangi prostej i łamanej. Łamana ma tę zaletę, " +
                "że pozwala na zwiększenie zakresu ruchu i zmniejsza naprężenia powstające w nadgarstkach. Łokcie powinny trwać nieruchomo(jak najbliżej głowy) podczas ćwiczenia. " +
                "Zakres ruchu:od pełnego wyprostu ramion, do pełnego zgięcia w łokciach. Przy pełnym zgięciu ramion, gdy sztanga znajduje się za głową, nie powinno się tracić nad nią kontroli(swobodne opuszczenie jej przeciąża mocno stawy łokciowe, co może prowadzić do kontuzji).Ćwiczenie można wykonywać również zastępując sztangę drążkiem wyciągu dolnego (prostym lub łamanym, bądź grubym sznurem zakończonym węzłami-stosujemy wtedy uchwyt równoległy). " +
                "Można również wykonywać nieco inną odmianę ćwiczenia ze sztangielką trzymaną oburącz. " +
                "Przy tej wersji należy pamiętać, o jednakowym angażowaniu w ćwiczenie obu rąk.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 9

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 29,
                Name = "PROSTOWNIE RAMIENIA ZE SZTANGIELKĄ W OPADZIE TUŁOWIA",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: głowy boczne i przyśrodkowe mięśni trójgłowych ramion" +
                "\nWykonanie: Przy wyprostowanych plecach pochylamy się do przodu i opieramy jedną ręką o ławkę. W drugiej trzymamy sztangielkę i unosimy ramię nieco ponad linię pleców(nie niżej)-przedramię prostopadle do podłogi. " +
                "Z tej pozycji pracując tylko tricepsem prostujemy ramię w łokciu unosząc ciężar aż do pełnego wyprostu. " +
                "W pozycji końcowej zatrzymujemy na moment ruch dla lepszego napięcia mięśni." +
                " Musimy zwracać szczególną uwagę na to, by w trakcie ćwiczenia w ruchu było jedynie przedramię(praca w stawie łokciowym).Nie wolno dopuszczać do bujania ramieniem. " +
                "Ruch opuszczania wolniejszy od unoszenia, z pełną kontrolą ciężaru..",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 9

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 30,
                Name = "POMPKI W PODPORZE TYŁEM",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: wszystkie głowy mięśni trójgłowych ramion" +
                "\nWykonanie: Wspaniałe ćwiczenie na zakończenie treningu-maksymalnie „dopompowuje” tricepsy." +
                " Polega na wykonywaniu ruchów opuszczania i unoszenia tułowia podpierając się o ławkę z tyłu, a nogi pozostają (działając jak zawias)oparte na drugiej ławce(dobrze jest, gdy ławka ta jest nieco wyższa od tej, na której trzymamy ręce). " +
                "Ramiona prostujemy do końca dla lepszego napięcia mięśni. Ruch opuszczania powolny, unoszenia nieco szybszy. Ćwiczenie to można wykonywać z uchwytem, lub ustawiając ławkę wzdłuż chwytamy ją na końcu po bokach(uchwyt równoległy). " +
                "Dla zwiększenia trudności ćwiczenia można zastosować dodatkowe obciążenie kładąc np. krążek na uda.Można też wykonywać np. kilka-kilkanaście powtórzeń z obciążeniem, po czym partner zdejmuje nam ciężar, a my wykonujemy jeszcze kilka-kilkanaście powtórzeń. " +
                "Taka metoda dodatkowo pobudzi mięśnie.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 9

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 31,
                Name = "SKŁONY W LEŻENIU PŁASKO",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie proste brzucha, skośne brzucha" +
                "\nWykonanie:  Kładziemy się na materacu lub ławce. Nogi ugięte, ręce nad głową i unosimy tułów w górę. Pierwsza do góry unosi się głowa, potem barki, a na końcu reszta tułowia. " +
                "Dla lepszego zaangażowania mięśni skośnych brzucha, w końcowej fazie unoszenia tułowia można wykonywać nim skręty. " +
                "Jest to jednak wersja trudniejsza i bardziej narażająca na ewentualne kontuzje(mocniej obciąża dolne partie grzbietu)." +
                "Nabieramy powietrza przed rozpoczęciem ruchu, a wypuszczamy je w trakcie unoszenia tułowia.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 10

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 32,
                Name = "UNOSZENIE NÓG W ZWISIE NA DRĄŻKU",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie proste brzucha, skośne brzucha, mięsnie zębate przednie" +
                "\nWykonanie:Chwytamy drążek prosty nachwytem lub podchwytem, jeżeli mamy kłopot z dłuższym utrzymaniem się na drążku, możemy zastosować paski. Unosimy nogi jak najwyżej do brody. " +
                "Można również w tym ćwiczeniu wprowadzić skręty tułowia w końcowej fazie unoszenia nóg, co mocniej zaangażuje do pracy mięśnie skośne brzucha." +
                " Jeszcze inna wersja(mocno angażująca mięśnie skośne)polega na jednoczesnym skręcie bioder wraz z unoszeniem nóg. " +
                "Osoby zaawansowane mogą w tym ćwiczeniu używać dodatkowego obciążenia zamocowanego do nóg, ale tylko jeżeli czują się na siłach-łatwo „przedobrzyć” i nabawić się bolesnej kontuzji. " +
                "Tempo ruchu umiarkowane, bez zrywów. Im mniejsze ugięcie nóg w kolanach, tym większy stopień trudności ćwiczenia, większe zaangażowanie mięśni zginaczy bioder(przy zmniejszeniu pracy mięsni brzucha) i większe napięcia w dolnym odcinku grzbietu.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 10

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 33,
                Name = "UNOSZENIE NÓG W PODPORZE",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: mięśnie proste brzucha, skośne brzucha." +
                "\nWykonanie: Stajemy plecami do specjalnej podpory, ramiona opieramy na poziomych poprzeczkach podpory, dłońmi chwytamy uchwyty, w tym momencie znajdujemy się już ponad podłogą." +
                " Z tej pozycji unosimy nogi w górę, w kierunku klatki piersiowej, jednocześnie uginając je w kolanach. Technika podobna, jak w unoszeniu nóg w zwisie, jednak mięśnie zaangażowane pod innym kątem. " +
                "W tym ćwiczeniu również należy pamiętać o zachowaniu pełnego zakresu ruchu-zmniejszanie go prowadzi do skracania mięśni. Tempo ruchu umiarkowane, bez zrywów. " +
                "Im mniejsze ugięcie nóg w kolanach, tym większy stopień trudności ćwiczenia, większe zaangażowanie mięśni " +
                "zginaczy bioder(przy zmniejszeniu pracy mięsni brzucha) i większe napięcia w dolnym odcinku grzbietu.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 10

            });

            modelBuilder.Entity<Power>().HasData(new Power
            {
                Id = 34,
                Name = "SKRĘTY TUŁOWIA",
                Description = "Główne mięśnie zaangażowane w ćwiczeniu: skośne brzucha, proste brzucha, prostowniki grzbietu." +
                "\nWykonanie: Ćwiczenie to można wykonać zarówno w pozycji siedzącej, jak i " +
                "stojącej-na maszynie lub, jeśli takiej nie posiadamy-za pomocą gryfu sztangi(tylko nie „olimpijskiej”- może być zbyt ciężki)zaawansowani mogą pozwolić sobie na użycie pewnego obciążenia, oczywiście z umiarem. " +
                "Zbyt duże przeciąża dolny odcinek kręgosłupa. " +
                "W pozycji stojącej- stajemy w rozkroku szerszym niż barki, gryf kładziemy na karku, ramiona oparte szeroko na gryfie. " +
                "W pozycji siedzącej(na maszynie) chwytamy rączki maszyny, tułów wyprostowany przez cały czas wykonania ćwiczenia, nogi w jednakowej pozycji(ugięte w kolanach i skierowane do przodu-najlepiej, gdy są zaparte- dla lepszej stabilizacji tułowia)w trakcie całego ćwiczenia.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 10

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 35,
                Name = "SKOKI NA SKAKANCE",
                Description = "Skakanka musi zostać dobrana tak aby ćwiczenie było wykonywane swobodnie dla trenującego",
                TimeLength = 3,
                ExerciseTypeId = 11

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 36,
                Name = "PRZYSIADY Z OBCIĄŻENIEM (CIĘŻAR DO 10KG)",
                Description = "Dynamiczne przysiady z obciążeniem. Przysiady mogą być uzupełnione o wspięcie na palce lub o dodatkowy wyskok" +
                "na prostych nogach" +
                "\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego. Jeżeli zawodnik jest bardzo młody można zastosować" +
                "przysiad bez obciążenia (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });


            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 37,
                Name = "RZUT PIŁKĄ LEKARSKĄ",
                Description = "Dynamiczne ciosy z wyrzutem piłki lekarskiej w stronę partnera. Ciosy proste, sierpowe oraz z dołu." +
                "\n WAŻNE: Bardzo ważne, aby ciężar piłki został dobrany do wieku oraz predyspozycji trenującego. Partner również powinien zostać dobrany" +
                "mniej więcej wagowo i wzrostowo" +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });
            
            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 38,
                Name = "ĆWICZENIA Z HANTLAMI",
                Description = "Dynamiczne ciosy trzymając hantle. Ciosy proste, sierpowe oraz z dołu." +
                "\n WAŻNE: Bardzo ważne, aby ciężar hantli (do 5kg.) został dobrany do wieku oraz predyspozycji trenującego."+
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            }); 
            
            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 39,
                Name = "ĆWICZENIA Z CIĘŻARKAMI",
                Description = "Dynamiczne ciosy trzymając hantle. Ciosy proste, sierpowe." +
                "\n WAŻNE: Bardzo ważne, aby ciężarki (do 2kg.) zostały dobrane do wieku oraz predyspozycji trenującego."+
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });  
            



            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 40,
                Name = "BIEG BOKSERSKI Z CIĘŻARKAMI",
                Description = "Dynamiczny bieg bokserski - ciosy z wyrzutem ciężarków." +
                "\n WAŻNE: Bardzo ważne, aby ciężarki (do 2kg.) zostały dobrane do wieku oraz predyspozycji trenującego." +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });
            
            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 41,
                Name = "WALKA Z CIENIEM Z CIĘŻARKAMI",
                Description = "Dynamiczna walka z cieniem - ciosy z wyrzutem ciężarków." +
                "\n WAŻNE: Bardzo ważne, aby ciężarki (do 1,5kg.) zostały dobrane do wieku oraz predyspozycji trenującego." +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 42,
                Name = "BRZUSZKI",
                Description = "Dowolne ćwiczenie na mięśnie brzucha (preferowane skłony do lekko zgiętych nóg)." +
                "Dodatkowo można dołożyć obciążenie w formie krążka do sztangi." +
                "\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego." +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 43,
                Name = "POMPKI",
                Description = "Dynamiczne pompki przez całe 3 minuty. Zamiast pompek ćwiczenie można zastąpić np dynamicznym wyrzutem krążka lub sztangi (Do 15kg) stojąc na lekko" +
                "ugiętych nogach, ",
                TimeLength = 3,
                ExerciseTypeId = 11

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 44,
                Name = "PODCIĄGANIE NA DRĄŻKU (NACHWYTEM)",
                Description = "Dynamiczne podciąganie nachwytem na drążku. Pamiętajmy, że trzy minuty podciągania to mimo wszystko dość długo. W takim wypadku jeżeli zawodnik" +
                "nie może podciągać się na drążku przez trzy minuty bez przerwy powinien wykonywać ćwiczenie aż do całkowitego zmęczenia mięśniowego, następnie po przerwie około 30 sekund" +
                "powinien natychmiast powrócić do ćwiczenia aby następnie znów wykonać je aż do kompletnego zmęczenia mięśni.",
                TimeLength = 3,
                ExerciseTypeId = 11

            });
            
            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 45,
                Name = "MACHANIE CIĘŻAREM PO OKRĘGU W JEDNĄ A POTEM W DRUGĄ STRONĘ (CIĘŻAR DO 15KG.)",
                Description = "Krążenia krążka o wadzę do 15kg. Krążenie ciała powinno zostać wykonane w pozycji stabilnej na lekko ugiętych nogach" +
                "tak aby nieodrywać stóp od podłoża. Celem takiego ćwiczenia jest wyizolowanie  " +
                "" +
                "\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego." +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });

            modelBuilder.Entity<Strength>().HasData(new Strength
            {
                Id = 46,
                Name = "MACHANIE CIĘŻAREM PO OKRĘGU W JEDNĄ A POTEM W DRUGĄ STRONĘ (CIĘŻAR DO 15KG.)",
                Description = "Krążenia krążka o wadzę do 15kg. Krążenie ciała powinno zostać wykonane w pozycji stabilnej na lekko ugiętych nogach" +
                "tak aby nieodrywać stóp od podłoża. Celem takiego ćwiczenia jest wyizolowanie  " +
                "" +
                "\n WAŻNE: Bardzo ważne, aby ciężar został dobrany do wieku oraz predyspozycji trenującego." +
                " (Obciążenie powinien dobierać wykwalifikowany trener)",
                TimeLength = 3,
                ExerciseTypeId = 11

            });
            
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 47,
                Name = "LEWY PROSTY",
                Description = "Podstawa zarówno Polskiego jak i światowego dobrego boksu. Lewy cios prosty powinien zostać wykonany z zachowaniem " +
                "zasad wykonania prawidłowego ciosu a więc zachować prawidłowy skręt bioder w celu przedłużenia ciosu." +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 48,
                Name = "PRAWY PROSTY",
                Description = "Bezpośredni prawy cios prosty" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 49,
                Name = "LEWY + PRAWY PROSTY",
                Description = "Ciosy proste w kombinacji dwóch ciosów prostych." +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub/i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            }); 
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 50,
                Name = "LEWY - PRAWY - LEWY PROSTY",
                Description = "Ciosy proste w kombinacji trzech ciosów prostych." +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });  

            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 51,
                Name = "LEWY - PRAWY - LEWY SIERP",
                Description = "Kombinacja ciosów prostych i lewego ciosu sierpowego" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });

            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 52,
                Name = "LEWY - PRAWY - UNIK - PRAWY SIERP",
                Description = "Kombinacja ciosów prostych i prawego ciosu sierpowego" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 53,
                Name = "LEWY - PRAWY - UNIK - LEWY Z DOŁU",
                Description = "Kombinacja ciosów prostych i lewego ciosu z dołu" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 54,
                Name = "LEWY - PRAWY - UNIK - PRAWY Z DOŁU",
                Description = "Kombinacja ciosów prostych i prawego ciosu z dołu" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });        
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 55,
                Name = "LEWY - PRAWY Z DOŁU - LEWY SIERP",
                Description = "Kombinacja ciosów z dołu i lewego ciosu sierpowego" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });
            
            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 56,
                Name = "LEWY - PRAWY Z DOŁU - UNIK - PRAWY SIERP",
                Description = "Kombinacja ciosów z dołu i prawego ciosu sierpowego" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });

            modelBuilder.Entity<Technique>().HasData(new Technique
            {
                Id = 57,
                Name = "LEWY - PRAWY Z DOŁU - UNIK - PRAWY SIERP - LEWY SIERP",
                Description = "Kombinacja ciosów z dołu i sierpowych" +
                "\nWAŻNE: Niesłuchanie istotną kwestią jest oczywiście dowolny unik po pojedynczym ciosie lub / i obowiążkowo po zakończeniu kombinacji",
                TimeLength = 3,
                ExerciseTypeId = 12

            });


            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 58,
                Name = "Seria na worek 30 sekund",
                Description = "Szybkie serie uderzania na worek po upływie trzydziestu sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać 12. Przerwa to również trzydzieści sekund",
                TimeLength = 30,
                Rounds = 12,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 59,
                Name = "Seria na worek 20 sekund",
                Description = "Szybkie serie uderzania na worek po upływie dwudziesty sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać szesnaście. Przerwa powinna wyności czterdzieści sekund.",
                TimeLength = 20,
                Rounds = 16,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 60,
                Name = "Seria na worek 15 sekund",
                Description = "Szybkie serie uderzania na worek po upływie piętnastu sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności czterdzieści pięć sekund.",
                TimeLength = 15,
                Rounds = 18,
                ExerciseTypeId = 13

            });
            
            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 61,
                Name = "Seria na worek 10 sekund",
                Description = "Szybkie serie uderzania na worek po upływie dziesięciu sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności pięćdziesiąt sekund.",
                TimeLength = 10,
                Rounds = 24,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 62,
                Name = "Seria na worek 30 sekund",
                Description = "Szybkie serie uderzania na worek po upływie trzydziestu sekund następuje zmiana zawodnika. " +
    "Takich rund zawodnik powinien wykonać 12. Przerwa to również trzydzieści sekund",
                TimeLength = 30,
                Rounds = 12,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 63,
                Name = "Seria na worek 20 sekund",
                Description = "Szybkie serie uderzania na worek po upływie dwudziesty sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać szesnaście. Przerwa powinna wyności czterdzieści sekund.",
                TimeLength = 20,
                Rounds = 16,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 64,
                Name = "Seria na worek 15 sekund",
                Description = "Szybkie serie uderzania na worek po upływie piętnastu sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności czterdzieści pięć sekund.",
                TimeLength = 15,
                Rounds = 18,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<Speed>().HasData(new Speed
            {
                Id = 65,
                Name = "Seria na worek 10 sekund",
                Description = "Szybkie serie uderzania na worek po upływie dziesięciu sekund następuje zmiana zawodnika. " +
                "Takich rund zawodnik powinien wykonać osiemnaście. Przerwa powinna wyności pięćdziesiąt sekund.",
                TimeLength = 10,
                Rounds = 24,
                ExerciseTypeId = 13

            });

            modelBuilder.Entity<FinalExercise>().HasData(new FinalExercise
            {
                Id = 62,
                Name = "Skakanka",
                Description = "Jedno z ćwiczeń końcowych jest oczywiście skok na skakance. Skoki wykonujemy przez całę 3 minuty.",
                TimeLength = 3,
                ExerciseTypeId = 14

            });
            
            modelBuilder.Entity<FinalExercise>().HasData(new FinalExercise
            {
                Id = 63,
                Name = "Walka z cieniem",
                Description = "Walka z cienie. Długie dokładnie ruchy ",
                TimeLength = 3,
                ExerciseTypeId = 14

            });

            modelBuilder.Entity<FinalExercise>().HasData(new FinalExercise
            {
                Id = 64,
                Name = "Ćwiczenia na brzuch",
                Description = "Brzuszki lub inne ćwiczenia na mięśnie brzucha. Łącznie 120 powtórzeń lub więcej",
                TimeLength = 120,
                ExerciseTypeId = 14

            });


            //Add type of workouts
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 1,
                Name = "Rozgrzewka w biegu",
                Description = "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. " +
                "Ma ona szczególne znaczenie w zapobieganiu urazom." +
                " Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. " +
                "Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 2,
                Name = "Rozgrzewka w marszu",
                Description = "Przejście do marszu ma na celu uspokojenie i wyrównanie oddechu z jednoczesnym dogrzaniem konkretnych partii mięśni oraz stawów." +
                "Partię mięśni oraz stawów, które będą brały główny udział w treningu."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 3,
                Name = "Rozgrzewka w miejscu",
                Description = "Rozgrzewka miejscu na na celu dodatkową aktywację układu nerwowego ze względu na charakterystykę treningu bokserskiego. " +
                "Trening bokserski wiąże się z ciągłąd zmianą dynamiki a zatem częstej zmiany tętna. Przygotowanie do tego ma nam dać właśnie rozgrzewka w miejscu," +
                "która zawiera ćwiczenia dynamiczne."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 4,
                Name = "Trening Siłowy",
                Description = "Trening na poprawę siły-każda grupa mięśniowa trenowana raz w tygodniu. Trening na dużych ciężarach z małą " +
                "ilością powtórzeń w seriach(8-10).Przerwy pomiędzy seriami wydłużamy do 3-5 minut. Na duże grupy wykonujemy 8-10 serii," +
                " na małe 6-8 serii(plus 2-3 serie rozgrzewkowe w obu przypadkach)." +
                "Trening oparty na podstawowych ćwiczeniach(wyciskania, przysiady, uginania i wyprosty ramion, itp.) " +
                "z użyciem wolnych ciężarów(sztanga, sztangielki).Czas trwania: 4-8 tygodni(nie dłużej) Oczywiście jest to tylko bardzo " +
                "ogólny zapis, a od tych zasad są odstępstwa, ponieważ każdy organizm reaguje inaczej na te same bodźce. I tak w rzeczywistości," +
                " każdy powinien wypracować sobie osobisty program-adekwatny do indywidualnych predyspozycji organizmu, a zapis ogólny powinien służyć, " +
                "jako podstawa do dalszych prób wypracowania tego programu."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 5,
                Name = "Trening Siłowy - Klatki piersiowej",
                Description = "Dobrze rozwinięta klatka piersiowa nie tylko świadczy o tężyźnie fizycznej, " +
                "ale także spełnia bardzo istotną rolę dla naszego zdrowia-chroni dwa najważniejsze organy: serce i płuca." +
                "Aby w pełni wszechstronnie rozwinąć muskulaturę klatki piersiowej należy atakować ja pod różnymi kątami - " +
                "jakie konkretnie ćwiczenia służą rozwojowi mięśni piersiowych i które części klatki rozwijają znajdziesz poniżej." +
                "Zalecane jest wykonywanie w pierwszej kolejności,(kiedy dysponujemy największym zasobem energii) ćwiczeń podstawowych-typowo siłowych" +
                " wyciskań(w zależności od osobistych priorytetów-płasko, bądź w skosie),a dopiero w dalszej fazie treningu włączanie ćwiczeń izolowanych," +
                " jak np. rozpiętki, przenoszenia(nie wymagają one tak dużych ciężarów - ważniejsza jest technika ich wykonywania). "


            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 6,
                Name = "Trening Siłowy - Mięśni Grzbietu",
                Description = "Mięsnie grzbietu są, według niektórych najważniejszą grupą dla naszego układu mięśniowego. Biorą udział we wszystkich czynnościach, jakie wykonujemy, szczególnie w pozycji stojącej. " +
                "To one stabilizują naszą sylwetkę w pionie(wespół z mięśniami brzucha)chroniąc przy tym nasz kręgosłup. Mówi się, że kto ma silne plecy, ten jest silny ogólnie. Jest w tym sporo prawdy, właśnie ze względu na wszechstronne zaangażowanie tej grupy mięśni" +
                " we wszystkich naszych czynnościach zarówno dnia codziennego, jak i treningowych. Wbrew pozorom trening mięśni grzbietu nie jest aż tak skomplikowany, jak sugerowałaby to ich budowa. Najważniejsze w ich rozwoju są ćwiczenia podstawowe- złożone. Istotne jest również to," +
                " że nie da się rozwinąć wszechstronnie mięśni grzbietu jednym lub dwoma ćwiczeniami. Wymagają one ataku wielostronnego, pod różnymi kątami. Które ćwiczenia angażują do pracy, jakie części mięsni grzbietu-znajdziesz poniżej. " +
                "Mięśnie grzbietu są grupą szczególnie narażoną na kontuzje, co jest bardzo niebezpieczne ze względu na funkcję ochronną kręgosłupa, jaką pełnią. I między innymi również dlatego powinniśmy szczególną uwagę poświęcać odpowiedniej rozgrzewce " +
                "tych mięśni(również stawów i ścięgien). Skręty, skłony tułowia, krążenia ramion i tym podobne ćwiczenia powinny stanowić nieodłączną część rozgrzewki, jako elementy gimnastyczne rozgrzewające stawy i ścięgna. Duże znaczenie mają również serie rozgrzewkowe z małym obciążeniem-szczególnie " +
                "w trudniejszych ćwiczeniach, które mocno obciążają dolny odcinek kręgosłupa i mięśni grzbietu(np. wiosłowaniu, martwym ciągu). Do tego celu również bardzo pomocne są wyciągi i ćwiczenia na nich." +
                " Pozwalają one na lepszą kontrolę ciężaru i dają możliwość dobrego ukrwienia mięsni.(np. przyciąganie linki wyciągu dolnego w siadzie płaskim)." +
                "W zasadzie wszystkie podane niżej ćwiczenia nadają się do wykonania na każdym poziomie zaawansowania, jednak niektóre zalecane są dla ćwiczących z pewnym stażem treningowym, " +
                "ze względu na trudną technikę i duże prawdopodobieństwo kontuzji(przy niewłaściwej technice wykonania). " +
                "Do takich ćwiczeń należą „martwe ciągi” wszelkiego typu i wiosłowanie ze sztangą w opadzie. " +
                "Aby ustrzec się kontuzji, które w przypadku tej grupy mięśniowej są tak częste i niebezpieczne należy bezwzględnie przestrzegać zasad poprawnego treningu-oto podstawowe z nich:" +
                "\n- przestrzeganie właściwej techniki ćwiczeń, " +
                "\n- elementem, który najczęściej jest przyczyną(poza małym doświadczeniem)błędów technicznych, jest wykonywanie ćwiczeń ze zbyt dużym obciążeniem " +
                "\n- aby nie „przeszkadzało” ono w poprawnym wykonaniu ćwiczenia powinno być dobrane ściśle do naszych możliwości w każdym konkretnym ćwiczeniu," +
                "\n- kolejnym elementem właściwej techniki jest tempo i płynność ruchów-tempo powinno być średnie i wolne " +
                "\n- tylko w takim wykonywane są ćwiczenia na mięśnie grzbietu, ruch powinien odbywać się płynnie, koniecznie z wyeliminowaniem wszelkiej gwałtowności," +
                "\n- właściwa pozycja / ułożenie ciała - bardzo istotny element-zaniedbany powoduje kontuzje-najczęstszym błędem jest robienie tzw. ”kociego grzbietu”, czyli wyginania w łuk grzbietu-szczególnie jego dolnego odcinka.Jest to spowodowane brakiem koncentracji i nadmiernym ciężarem użytym w ćwiczeniu."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 7,
                Name = "Trening Siłowy - Mięśni Nóg",
                Description = "Mięśnie nóg są bardzo mocne i wytrzymałe. " +
                "Każdego dnia muszą przenosić ciężar reszty ciała, utrzymując się w pionie. Warto więc o nie zadbać." +
                " Wprowadzając ćwiczenia na nogi do planu treningowego, warto pamiętać o tym, by zaczynać od największych ciężarów." +
                " Pozwoli to wykonać ćwiczenia poprawnie i zmniejszy ryzyko kontuzji wywołanej zmęczeniem, które jest nieodłączną częścią każdego treningu." +
                " Wysiłek warto rozpocząć od ćwiczeń wielostawowych i powoli przechodzić w stronę tych izolujących daną grupę mięśniową." +
                " Zanim przejdziemy do treningu, należy rozgrzać mięśnie i stawy, co zminimalizuje ryzyko kontuzji."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 8,
                Name = "Trening Siłowy - Mięśni Naramiennych",
                Description = "Mięśnie naramienne są jedną z najbardziej widocznych grup mięśniowych, a dobrze rozwinięte tzw. ”bary”  są świadectwem zdrowia i siły. Jak widać na powyższych szkicach mięśnie naramienne zbudowane są z trzech aktonów (par głów: przednich, bocznych i tylnych). " +
                "Każda para głów,to jakby osobne mięśnie i wymaga odrębnych ćwiczeń ukierunkowanych na rozwój konkretnej pary głów (aktonów)." +
                " We właściwym treningu (mającym na celu wszechstronny rozwój mięśni naramiennych) uwzględnić należy ćwiczenia na wszystkie aktony." +
                " Liczba serii ,ilość powtórzeń i ciężar,jaki stosujemy w treningu poszczególnych aktonów powinny być dostosowane do konkretnej pary głów. " +
                "Ponieważ mięśnie barków biorą aktytwny udział we wszystkich ćwiczeniach, w których pracują ramiona,to na przestrzeni tygodnia poszczególne aktony są w różnym stopniu zmęczone (w trakcie różnych ćwiczeń,różne głowy są zaangażowane) " +
                "i należy układając trening uwzględnić pracę, jaką wykonały na poprzedzających treningach (na inne grupy mięśniowe). " +
                "W związku z tym wykonywanie takiej samej ilości serii na wszystkie aktony mięśni naramiennych nie jest wskazane-doprowadzić może do przetrenowania jednych, a niedotrenowania innych aktonów. " +
                "Generalną zasadą jest, że stosujemy minimum jedno ćwiczenie na każdą parę głów."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 9,
                Name = "Trening Siłowy - Mięśni Ramion (triceps oraz przedramiona) ",
                Description = "Trzeba sobie uświadomić, że triceps stanowi 2/3 masy mięśniowej całego ramienia. " +
                "Chcąc mieć symetrycznie rozwinięte mięśnie ramion, należy temu mięśniowi poświęcić nieco więcej uwagi." +
                " Jego budowa (jest to mięsień trójgłowy- składający się z trzech głów)ściśle warunkuje charakter treningu-jego wielokierunkowość, która powinna pozwolić nam na wszechstronny rozwój wszystkich trzech głów. Które ćwiczenia i pozycje wpływają na rozwój poszczególnych głów, wyjaśnia poniżej przedstawiony opis."

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 10,
                Name = "Trening Siłowy - Mięśni Brzucha ",
                Description = "a wstępie należy zaznaczyć, że żadne nawet najbardziej wyszukane i najintensywniejsze ćwiczenia mięśni brzucha nie są w stanie zastąpić odpowiednio zbilansowanej diety. Jeśli nie będziemy jej przestrzegać, to owszem możemy wytrenować sobie mocne i silnie rozbudowane mięśnie brzucha, " +
                "ale pozostaną one ukryte pod warstwą tkanki tłuszczowej i będą niewidoczne, a co za tym idzie nie będą mogły spełniać jednej ze swoich ról-mianowicie roli estetycznej. " +
                "Panuje błędne przekonanie, że trening mięśni brzucha jest sam dla siebie rozgrzewką.(może dlatego, że wiele osób traktuje ćwiczenia na brzuch, jako rozgrzewkę przed treningami innych mięśni). Nic bardziej mylnego. " +
                "Trening mięśni brzucha powinien być poprzedzony rozgrzewką-nie gorszą niż przed treningiem innych partii umięśnienia." +
                " Prawidłowa rozgrzewka przed treningiem mięśni brzucha zawiera, poza ćwiczeniami aerobowymi( zwiększającymi temperaturę mięśni)-jak przy innych grupach mięśniowych, także odpowiednie ćwiczenia angażujące dolny odcinek grzbietu- np. skłony, skręty tułowia, krążenia bioder jak również mięśnie prostowniki bioder(bardzo aktywne w treningu mięśni brzucha)." +
                " Kolejnym błędem popełnianym w treningu mięśni brzucha są zbyt częste treningi, a co za tym idzie, zbyt krótki odpoczynek. "

            });


            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 11,
                Name = "Trening Wytrzymałościowy - Wytrzymałość szybkościowa",
                Description = "Wytrzymałość to zdolność organizmu do wykonywania wysiłku fizycznego przez długi czas, bez uszczerbku dla jego funkcji życiowych." +
                " To umiejętność zminimalizowania zmęczenia nabywana w czasie treningu. " +
                "Wytrzymałość szybkościowa to umiejętność wykonywania szybkich ruchów na niezmiennym poziomie, np. w trakcie walki. " +
                "Wytrzymałość jest fundamentem działań boksera pozwalającym mu na wykorzystanie wszystkich środków technicznych przez cały czas trwania walki." +
                " Jest ona tym ważniejsza, im dłużej trwa wysiłek fizyczny." +
                "\n Dobrą metodą trenowania wytrzymałości szybkościowej jest trening obwodowy." +
                " Liczba stacji powinna zawierać się w liczbie od 8 do 12"

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 12,
                Name = "Technika sportowa – sposób wykonania zadania ruchowego",
                Description = "Przygotowanie techniczne – proces opanowywania takiego zasobu zadań ruchowych (techniki działań), " +
                "który w połączeniu z cechami budowy ciała, sprawności itp. pozwala uzyskiwać racjonalne i efektywnie najlepsze wyniki sportowe w sposób zgodny z przepisami obowiązującymi " +
                "w danej dyscyplinie. " +
                "\nDobra technika powinna charakteryzować się:" +
                "\n- przyjęciem jednoznacznego celu ruchu;" +
                "\n- dobrze zaznaczonym przedziałem czasowo - przestrzennym(faza przygotowawcza, główna i końcowa ruchu) " +
                "\n- poprawnie wyrażonym przedziałem dynamiczno - czasowym(rytm, płynna kolejność napięć i rozluźnień)" +
                "\n- wysoką elastycznością(umiejętne pokonywanie i wykorzystanie oporów środowiska)" +
                "\n- wczesnym przewidywaniem ruchu(właściwe ustawienie koncepcji ruchu)" +
                "\n- przewidywaniem ruchów obcych(przeciwnik, wiatr, śliska nawierzchnia itp.)" +
                "\n WAŻNE: Trening techniki sportowej powinien zostać wykonany w parze z partnerem, który jest dobrany wzrostowo oraz wagowo" +
                "lub na tarczy u trenera. Podana technika w aplikacji jest techniką przykładową i oczywiście może ona być stosowana wymiennie w zależności od koncepcji trenerskiej" +
                "koncpecji treningu nadaną przez trenera."
            });
            
            
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 13,
                Name = "Trening Szybkościowo-wytrzymałościowy",
                Description = "Przygotowanie szybkościowe jest stosowane w okresie bezpośrednio przed startowym. W tym wypadku należy trenować szybkość ostatni " +
                "tydzień przed startem. Szybkie wydolnościowe serie na worku od kilkudziesięciu do kilku sekund na 'rundę'. "
            });
            
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 14,
                Name = "Ćwiczenia końcowe",
                Description = "Ćwiczenia końcowe są już elementem uspokojenia pracy krążenia. Są one nadal wykonywane dokładnie natomiast już z innym natężeniem. "
                
            });

            modelBuilder.Entity<Planner>()
                .HasOne(x => x.Plan)
                .WithMany(x => x.Planners)
                .HasForeignKey(x => x.PlanId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public DbSet<WarmupOnGo> WarmupOnGo { get; set; }
        public DbSet<WarmupOnWalk> WarmupOnWalk { get; set; }
        public DbSet<WarmupOnPlace> WarmupOnPlace { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }
        public DbSet<Power> Power { get; set; }
        public DbSet<Technique> Technique { get; set; }
        public DbSet<Strength> Strength { get; set; }
        public DbSet<Speed> Speed { get; set; }    
        public DbSet<FinalExercise> Finals { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Planner> Planners { get; set; }

    }
}

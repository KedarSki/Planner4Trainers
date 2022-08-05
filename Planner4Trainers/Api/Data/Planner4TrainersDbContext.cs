using Api.Entities.Trainings;
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
                TimeLength = 10,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 2,
                Name = "Krążenia ramion w przód oraz w tył - Naprzemiennie",
                Description = "Ćwiczenie (Wykonujemy krążenia naprzemiennie oburącz) najpierw 15 sekund w przód a następnie 15 sekund w tył.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 3,
                Name = "Skip-A",
                Description = "Naprzemienne kolan w biegu do momentu osiągnięcia kątu prostego między udem a tłowiem.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 4,
                Name = "Skip-C",
                Description = "Naprzemienne uderzanie piętami o pośladki.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 5,
                Name = "Krążenie ramion w przód oraz w tył - Jednocześnie",
                Description = "Ćwiczenie wykonujemy w biegu lub podczas przeskoków nogami.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 6,
                Name = "Krok odstawno dostawny twarzą do środka sali.",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarzą do środka sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 7,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 8,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });


            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 9,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<WarmupOnGo>().HasData(new WarmupOnGo
            {
                Id = 10,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });


            // Warmup while walking

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 1,
                Name = "Marsz",
                Description = "Zwykły marsz w celu delikatnego uspokojena oddechu.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 2,
                Name = "Wymachy ramion góra-dół",
                Description = "Wymachy ramion w przeciwnym kierunku do nóg - Ręka musi być wyprostowana w stawie łokciowym.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 3,
                Name = "Wymachy ramion na bogi z wykrokiem",
                Description = "Wymachy ramion na przemianstronnie w przeciwnym kierunku do nóg. Wymach ten wymaga jednej ręki wyprostowanej na bok a drugiej zgiętej w łokciu.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 4,
                Name = "Ciosy proste w marszu",
                Description = "Cios prosty wykonany na pełnym wyproście w stawie łokciowym. Z lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 5,
                Name = "Ciosy sierpowe w marszu",
                Description = "Cios sierpowy wykonany ze skrętem oraz lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 6,
                Name = "Ciosy podbródkowe w marszu",
                Description = "Cios podbródkowy wykonany z lekkim przeniesieniem ciężaru ciała oraz lekko zgiętym tłowiem (pozycja bokserska)" +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<WarmupOnWalk>().HasData(new WarmupOnWalk
            {
                Id = 7,
                Name = "Wymachy wyprostowanych ramion do wyprostowanej nogi",
                Description = "Wymach wyprostowanej ręki w łokciu do przeciwnej wyprostowanej w kolanie nogi.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            //Warmup while standing.

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 1,
                Name = "Skłony tłowia do ziemi z wyprostem",
                Description = "Skłony tłowia do ziemi na wyprostowanych w kolanach nogach w delikatnym rozkroku",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 2,
                Name = "Skręty tłowia do kostek",
                Description = "Skłony na wyprostowanych nogach w delikatnym rozkroku, ręce w pełnym wyproście na bok i dotykamy lewą rękę do prawej nogi" +
                "i odwrotnie.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 3,
                Name = "Skręty tłowia w przód i w tył",
                Description = "Skręty tłowia podczas wykonywania tłów należy pochylić do skłonu w przód a następnie odchylając w tył.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 4,
                Name = "Cios sierpowy ze skłonem do kostki",
                Description = "W delikatnym rozkroku wykonać dynamiczny cios sierpowy i po każdym ciosie wykonać skłon do kostki przeciwnej do ręki." +
                "Ilość powtórzeń 5 na stronę lub 30 sekund.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });


            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 5,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach. Ilość powtórzeń ciągłych przez 30 sekund lub 15 powtórzeń.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 6,
                Name = "Pompki",
                Description = "Podpór przodem przy którym podnosimy i opuszczamy ciężąr ciałą. Ilość powtórzeń wykonujemy przez 30 sekund " +
                "lub 15 powtórzeń.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 7,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<WarmupOnPlace>().HasData(new WarmupOnPlace
            {
                Id = 8,
                Name = "Wyrzuty nóg do tyłu",
                Description = "Z pozycji stojącej dynamiczne zejście do przysiadu. Następnie wyrzut nóg do tyłu przechodząc szybko do podporu przodem.",
                TimeLength = 0.5M,
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
                "ilością powtórzeń w seriach(8-1).Przerwy pomiędzy seriami wydłużamy do 3-5 minut. Na duże grupy wykonujemy 8-10 serii," +
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
                "Aby ustrzec się kontuzji, które w przypadku tej grupy mięśniowej są tak częste i niebezpieczne należy bezwzględnie przestrzegać zasad poprawnego treningu-oto podstawowe z nich:"+
                "\n- przestrzeganie właściwej techniki ćwiczeń, " +
                "\n- elementem, który najczęściej jest przyczyną(poza małym doświadczeniem)błędów technicznych, jest wykonywanie ćwiczeń ze zbyt dużym obciążeniem " +
                "\n- aby nie „przeszkadzało” ono w poprawnym wykonaniu ćwiczenia powinno być dobrane ściśle do naszych możliwości w każdym konkretnym ćwiczeniu," +
                "\n- kolejnym elementem właściwej techniki jest tempo i płynność ruchów-tempo powinno być średnie i wolne " +
                "\n- tylko w takim wykonywane są ćwiczenia na mięśnie grzbietu, ruch powinien odbywać się płynnie, koniecznie z wyeliminowaniem wszelkiej gwałtowności," +
                "\n- właściwa pozycja / ułożenie ciała - bardzo istotny element-zaniedbany powoduje kontuzje-najczęstszym błędem jest robienie tzw. ”kociego grzbietu”, czyli wyginania w łuk grzbietu-szczególnie jego dolnego odcinka.Jest to spowodowane brakiem koncentracji i nadmiernym ciężarem użytym w ćwiczeniu."

            });

        }

        public DbSet<WarmupOnGo> WarmupOnGo { get; set; }
        public DbSet<WarmupOnWalk> WarmupOnWalk { get; set; }
        public DbSet <WarmupOnPlace> WarmupOnPlace { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }
        public DbSet<Power> Power { get; set; }
        public DbSet<Technique> Technique { get; set; }
        public DbSet<Strength> Strength { get; set; }
        public DbSet<Speed> Speed { get; set; }


    }
}

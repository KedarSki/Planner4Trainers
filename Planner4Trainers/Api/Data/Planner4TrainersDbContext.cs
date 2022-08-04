﻿using Api.Entities.Trainings;
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
                Name = "Wyciskanie sztangi w leżeniu na ławce poziomej.",
                Description = "WAŻNE!: Pierwsze dwie serie wykonujemy rozgrzewkowo dobierając mniejszy ciężar." +
                "Główne mięśnie zaangażowane w ćwiczeniu:" +
                " cała grupa mięśni klatki piersiowej, mięśnie trójgłowe ramion, przednie aktony mięśni naramiennych.",
                Repeats = 10,
                Series = 8,
                ExerciseTypeId = 4
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

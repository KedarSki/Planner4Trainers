using Api.Entities.Trainings;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Planner4TrainersDbContext:DbContext
    {
        Planner4TrainersDbContext(DbContextOptions<Planner4TrainersDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Warmups exercises

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 1,
                Name = "Bieg - Trucht",
                Description = "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. " +
                "Ma ona szczególne znaczenie w zapobieganiu urazom." +
                " Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. " +
                "Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu.",
                TimeLength = 10,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 2,
                Name = "Krążenia ramion w przód oraz w tył - Naprzemiennie",
                Description = "Ćwiczenie (Wykonujemy krążenia naprzemiennie oburącz) najpierw 15 sekund w przód a następnie 15 sekund w tył.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1

            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 3,
                Name = "Skip-A",
                Description = "Naprzemienne kolan w biegu do momentu osiągnięcia kątu prostego między udem a tłowiem.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 4,
                Name = "Skip-C",
                Description = "Naprzemienne uderzanie piętami o pośladki.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 5,
                Name = "Krążenie ramion w przód oraz w tył - Jednocześnie",
                Description = "Ćwiczenie wykonujemy w biegu lub podczas przeskoków nogami.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 6,
                Name = "Krok odstawno dostawny twarzą do środka sali.",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarzą do środka sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 7,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 7,
                Name = "Krok odstawno dostawny twarzą na zewnątrz",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });


            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 8,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 8,
                Name = "Przeplatanka twarzą do środka sali",
                Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                TimeLength = 0.5M,
                ExerciseTypeId = 1
            });


            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 9,
                Name = "Marsz",
                Description = "Zwykły marsz w celu delikatnego uspokojena oddechu.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 10,
                Name = "Wymachy ramion góra-dół",
                Description = "Wymachy ramion w przeciwnym kierunku do nóg - Ręka musi być wyprostowana w stawie łokciowym.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 11,
                Name = "Wymachy ramion na bogi z wykrokiem",
                Description = "Wymachy ramion na przemianstronnie w przeciwnym kierunku do nóg. Wymach ten wymaga jednej ręki wyprostowanej na bok a drugiej zgiętej w łokciu.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 12,
                Name = "Ciosy proste w marszu",
                Description = "Cios prosty wykonany na pełnym wyproście w stawie łokciowym. Z lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 13,
                Name = "Ciosy sierpowe w marszu",
                Description = "Cios sierpowy wykonany ze skrętem oraz lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku." +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 14,
                Name = "Ciosy podbródkowe w marszu",
                Description = "Cios podbródkowy wykonany z lekkim przeniesieniem ciężaru ciała oraz lekko zgiętym tłowiem (pozycja bokserska)" +
                "Cios w przeciwnym kierunku do kroku.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 15,
                Name = "Wymachy wyprostowanych ramion do wyprostowanej nogi",
                Description = "Wymach wyprostowanej ręki w łokciu do przeciwnej wyprostowanej w kolanie nogi.",
                TimeLength = 0.5M,
                ExerciseTypeId = 2
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 16,
                Name = "Skłony tłowia do ziemi z wyprostem",
                Description = "Skłony tłowia do ziemi na wyprostowanych w kolanach nogach w delikatnym rozkroku",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 17,
                Name = "Skręty tłowia do kostek",
                Description = "Skłony na wyprostowanych nogach w delikatnym rozkroku, ręce w pełnym wyproście na bok i dotykamy lewą rękę do prawej nogi" +
                "i odwrotnie.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 18,
                Name = "Skręty tłowia w przód i w tył",
                Description = "Skręty tłowia podczas wykonywania tłów należy pochylić do skłonu w przód a następnie odchylając w tył.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 19,
                Name = "Cios sierpowy ze skłonem do kostki",
                Description = "W delikatnym rozkroku wykonać dynamiczny cios sierpowy i po każdym ciosie wykonać skłon do kostki przeciwnej do ręki.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });


            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 20,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 21,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            modelBuilder.Entity<Exercise>().HasData(new Exercise
            {
                Id = 21,
                Name = "Przysiady",
                Description = "Przysiady na złączonych nogach.",
                TimeLength = 0.5M,
                ExerciseTypeId = 3
            });

            //Add type of workouts
            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 1,
                Name = "Rozgrzewka w biegu"

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 2,
                Name = "Rozgrzewka w marszu"

            });

            modelBuilder.Entity<ExerciseType>().HasData(new ExerciseType
            {
                Id = 3,
                Name = "Rozgrzewka w miejscu"

            });

        }
    }
}

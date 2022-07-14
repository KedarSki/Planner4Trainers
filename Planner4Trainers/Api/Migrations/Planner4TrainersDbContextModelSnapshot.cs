﻿// <auto-generated />
using Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(Planner4TrainersDbContext))]
    partial class Planner4TrainersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api.Entities.Trainings.ExerciseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExerciseType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rozgrzewka w biegu"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rozgrzewka w marszu"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rozgrzewka w miejscu"
                        });
                });

            modelBuilder.Entity("Api.Entities.Trainings.WarmupOnGo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TimeLength")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WarmupOnGo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Rozgrzewka w treningu sportowym będąca elementem części wstępnej jest nieodłączną i wręcz niezbędną częścią treningu. Ma ona szczególne znaczenie w zapobieganiu urazom. Jest zestawem czynności „nisko-wysiłkowych”, jak np. szybki marsz lub wolny bieg, które należy wykonywać przed przystąpieniem do ćwiczeń rozciągających i do bardziej intensywnego wysiłku. Rozgrzewka przygotowuje układ oddechowy, sercowo-naczyniowy, układ nerwowy i mięśniowo-szkieletowy do wysiłku w części głównej poprzez stopniowy wzrost obciążenia tych układów tak, aby były one w stanie podołać bardziej intensywnemu wysiłkowi fizycznemu.",
                            ExerciseTypeId = 1,
                            Name = "Bieg - Trucht",
                            TimeLength = 10m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ćwiczenie (Wykonujemy krążenia naprzemiennie oburącz) najpierw 15 sekund w przód a następnie 15 sekund w tył.",
                            ExerciseTypeId = 1,
                            Name = "Krążenia ramion w przód oraz w tył - Naprzemiennie",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Naprzemienne kolan w biegu do momentu osiągnięcia kątu prostego między udem a tłowiem.",
                            ExerciseTypeId = 1,
                            Name = "Skip-A",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Naprzemienne uderzanie piętami o pośladki.",
                            ExerciseTypeId = 1,
                            Name = "Skip-C",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Ćwiczenie wykonujemy w biegu lub podczas przeskoków nogami.",
                            ExerciseTypeId = 1,
                            Name = "Krążenie ramion w przód oraz w tył - Jednocześnie",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarzą do środka sali.",
                            ExerciseTypeId = 1,
                            Name = "Krok odstawno dostawny twarzą do środka sali.",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                            ExerciseTypeId = 1,
                            Name = "Krok odstawno dostawny twarzą na zewnątrz",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                            ExerciseTypeId = 1,
                            Name = "Krok odstawno dostawny twarzą na zewnątrz",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                            ExerciseTypeId = 1,
                            Name = "Przeplatanka twarzą do środka sali",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Ćwiczenie wykonujemy odstawiając i dostawiając nogi twarząna zewnątrz sali.",
                            ExerciseTypeId = 1,
                            Name = "Przeplatanka twarzą do środka sali",
                            TimeLength = 0.5m
                        });
                });

            modelBuilder.Entity("Api.Entities.Trainings.WarmupOnPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TimeLength")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WarmupOnPlace");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Skłony tłowia do ziemi na wyprostowanych w kolanach nogach w delikatnym rozkroku",
                            ExerciseTypeId = 3,
                            Name = "Skłony tłowia do ziemi z wyprostem",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Skłony na wyprostowanych nogach w delikatnym rozkroku, ręce w pełnym wyproście na bok i dotykamy lewą rękę do prawej nogii odwrotnie.",
                            ExerciseTypeId = 3,
                            Name = "Skręty tłowia do kostek",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Skręty tłowia podczas wykonywania tłów należy pochylić do skłonu w przód a następnie odchylając w tył.",
                            ExerciseTypeId = 3,
                            Name = "Skręty tłowia w przód i w tył",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 4,
                            Description = "W delikatnym rozkroku wykonać dynamiczny cios sierpowy i po każdym ciosie wykonać skłon do kostki przeciwnej do ręki.Ilość powtórzeń 5 na stronę lub 30 sekund.",
                            ExerciseTypeId = 3,
                            Name = "Cios sierpowy ze skłonem do kostki",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Przysiady na złączonych nogach. Ilość powtórzeń ciągłych przez 30 sekund lub 15 powtórzeń.",
                            ExerciseTypeId = 3,
                            Name = "Przysiady",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Podpór przodem przy którym podnosimy i opuszczamy ciężąr ciałą. Ilość powtórzeń wykonujemy przez 30 sekund lub 15 powtórzeń.",
                            ExerciseTypeId = 3,
                            Name = "Pompki",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Przysiady na złączonych nogach.",
                            ExerciseTypeId = 3,
                            Name = "Przysiady",
                            TimeLength = 0.5m
                        });
                });

            modelBuilder.Entity("Api.Entities.Trainings.WarmupOnWalk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TimeLength")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("WarmupOnWalk");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Zwykły marsz w celu delikatnego uspokojena oddechu.",
                            ExerciseTypeId = 2,
                            Name = "Marsz",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Wymachy ramion w przeciwnym kierunku do nóg - Ręka musi być wyprostowana w stawie łokciowym.",
                            ExerciseTypeId = 2,
                            Name = "Wymachy ramion góra-dół",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Wymachy ramion na przemianstronnie w przeciwnym kierunku do nóg. Wymach ten wymaga jednej ręki wyprostowanej na bok a drugiej zgiętej w łokciu.",
                            ExerciseTypeId = 2,
                            Name = "Wymachy ramion na bogi z wykrokiem",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cios prosty wykonany na pełnym wyproście w stawie łokciowym. Z lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku.Cios w przeciwnym kierunku do kroku.",
                            ExerciseTypeId = 2,
                            Name = "Ciosy proste w marszu",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cios sierpowy wykonany ze skrętem oraz lekko zgiętym tłowiem (pozycja bokserska) wraz ze skrętem barku.Cios w przeciwnym kierunku do kroku.",
                            ExerciseTypeId = 2,
                            Name = "Ciosy sierpowe w marszu",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Cios podbródkowy wykonany z lekkim przeniesieniem ciężaru ciała oraz lekko zgiętym tłowiem (pozycja bokserska)Cios w przeciwnym kierunku do kroku.",
                            ExerciseTypeId = 2,
                            Name = "Ciosy podbródkowe w marszu",
                            TimeLength = 0.5m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Wymach wyprostowanej ręki w łokciu do przeciwnej wyprostowanej w kolanie nogi.",
                            ExerciseTypeId = 2,
                            Name = "Wymachy wyprostowanych ramion do wyprostowanej nogi",
                            TimeLength = 0.5m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

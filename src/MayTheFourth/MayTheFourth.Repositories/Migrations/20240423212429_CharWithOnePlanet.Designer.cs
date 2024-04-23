﻿// <auto-generated />
using System;
using MayTheFourth.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MayTheFourth.Repositories.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240423212429_CharWithOnePlanet")]
    partial class CharWithOnePlanet
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.Property<Guid>("CharactersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.HasKey("CharactersId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CharacterMovie");
                });

            modelBuilder.Entity("MayTheFourth.Entities.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("BirthYear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EyeColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HairColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PlanetId")
                        .HasColumnType("uuid");

                    b.Property<string>("SkinColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Characters", (string)null);
                });

            modelBuilder.Entity("MayTheFourth.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Episode")
                        .HasColumnType("integer");

                    b.Property<string>("OpeningCrawl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("MayTheFourth.Entities.Planet", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Climate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Diameter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gravity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrbitalPeriod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Population")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RotationPeriod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SurfaceWater")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Planets", (string)null);
                });

            modelBuilder.Entity("MayTheFourth.Entities.Starship", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("CargoCapacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Consumables")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CostInCredits")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Crew")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HyperdriveRating")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Length")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MGLT")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaxSpeed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Passengers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Starships", (string)null);
                });

            modelBuilder.Entity("MayTheFourth.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("CargoCapacity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Consumables")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CostInCredits")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Crew")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Length")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MaxSpeed")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Passengers")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Vehicles", (string)null);
                });

            modelBuilder.Entity("MoviePlanet", b =>
                {
                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PlanetsId")
                        .HasColumnType("uuid");

                    b.HasKey("MoviesId", "PlanetsId");

                    b.HasIndex("PlanetsId");

                    b.ToTable("MoviePlanet");
                });

            modelBuilder.Entity("MovieStarship", b =>
                {
                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("StarshipsId")
                        .HasColumnType("uuid");

                    b.HasKey("MoviesId", "StarshipsId");

                    b.HasIndex("StarshipsId");

                    b.ToTable("MovieStarship");
                });

            modelBuilder.Entity("MovieVehicle", b =>
                {
                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("VehiclesId")
                        .HasColumnType("uuid");

                    b.HasKey("MoviesId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("MovieVehicle");
                });

            modelBuilder.Entity("CharacterMovie", b =>
                {
                    b.HasOne("MayTheFourth.Entities.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MayTheFourth.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MayTheFourth.Entities.Character", b =>
                {
                    b.HasOne("MayTheFourth.Entities.Planet", "Planet")
                        .WithMany("Characters")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("MoviePlanet", b =>
                {
                    b.HasOne("MayTheFourth.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MayTheFourth.Entities.Planet", null)
                        .WithMany()
                        .HasForeignKey("PlanetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieStarship", b =>
                {
                    b.HasOne("MayTheFourth.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MayTheFourth.Entities.Starship", null)
                        .WithMany()
                        .HasForeignKey("StarshipsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieVehicle", b =>
                {
                    b.HasOne("MayTheFourth.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MayTheFourth.Entities.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MayTheFourth.Entities.Planet", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}

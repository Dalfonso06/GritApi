﻿// <auto-generated />
using System;
using GritApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GritApi.Migrations
{
    [DbContext(typeof(WorkoutContext))]
    [Migration("20240601022312_AddedForeignKeyForRepRanges")]
    partial class AddedForeignKeyForRepRanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GritApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GritApi.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("MuscleGroupId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("WorkoutId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MuscleGroupId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("GritApi.Models.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroup");
                });

            modelBuilder.Entity("GritApi.Models.Routine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Routine");
                });

            modelBuilder.Entity("GritApi.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int?>("RoutineId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RoutineId");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("GritApi.Models.Exercise", b =>
                {
                    b.HasOne("GritApi.Models.MuscleGroup", "MuscleGroup")
                        .WithMany()
                        .HasForeignKey("MuscleGroupId");

                    b.HasOne("GritApi.Models.Workout", null)
                        .WithMany("Exercises")
                        .HasForeignKey("WorkoutId");

                    b.OwnsMany("GritApi.Models.RepRange", "Reps", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<int>("ExerciseId")
                                .HasColumnType("integer");

                            b1.Property<int>("MaxReps")
                                .HasColumnType("integer");

                            b1.Property<int>("MinReps")
                                .HasColumnType("integer");

                            b1.HasKey("Id");

                            b1.HasIndex("ExerciseId");

                            b1.ToTable("RepRange");

                            b1.WithOwner()
                                .HasForeignKey("ExerciseId");
                        });

                    b.Navigation("MuscleGroup");

                    b.Navigation("Reps");
                });

            modelBuilder.Entity("GritApi.Models.Workout", b =>
                {
                    b.HasOne("GritApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("GritApi.Models.Routine", null)
                        .WithMany("Workouts")
                        .HasForeignKey("RoutineId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("GritApi.Models.Routine", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("GritApi.Models.Workout", b =>
                {
                    b.Navigation("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}

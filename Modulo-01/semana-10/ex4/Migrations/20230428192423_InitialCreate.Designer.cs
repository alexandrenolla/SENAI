﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ex4.Context;

#nullable disable

namespace ex1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230428192423_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("ex4.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnswerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Score")
                        .HasColumnType("REAL");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId")
                        .IsUnique();

                    b.HasIndex("StudentId");

                    b.ToTable("Answer", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DisciplineName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Discipline", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Enunciation")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("QuizId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuizId");

                    b.ToTable("Question", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Quiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateClose")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOpen")
                        .HasColumnType("TEXT");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.ToTable("Quiz", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Period")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RA")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("ex4.Models.StudentDiscipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student_Discipline", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("ex4.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cpf")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("ex4.Models.Answer", b =>
                {
                    b.HasOne("ex4.Models.Question", "Question")
                        .WithOne("Answer")
                        .HasForeignKey("ex4.Models.Answer", "QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Question");

                    b.HasOne("ex4.Models.Student", "Student")
                        .WithMany("Answers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Student");

                    b.Navigation("Question");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ex4.Models.Discipline", b =>
                {
                    b.HasOne("ex4.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Teacher");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ex4.Models.Question", b =>
                {
                    b.HasOne("ex4.Models.Quiz", "Quiz")
                        .WithMany("Questions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Quiz");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("ex4.Models.Quiz", b =>
                {
                    b.HasOne("ex4.Models.Discipline", "Discipline")
                        .WithMany("Quizzes")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Discipline");

                    b.Navigation("Discipline");
                });

            modelBuilder.Entity("ex4.Models.Student", b =>
                {
                    b.HasOne("ex4.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("ex4.Models.Student", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ex4.Models.StudentDiscipline", b =>
                {
                    b.HasOne("ex4.Models.Discipline", "Discipline")
                        .WithMany("Students")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Discipline");

                    b.HasOne("ex4.Models.Student", "Student")
                        .WithMany("Disciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Student");

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ex4.Models.Teacher", b =>
                {
                    b.HasOne("ex4.Models.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("ex4.Models.Teacher", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ex4.Models.Discipline", b =>
                {
                    b.Navigation("Quizzes");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("ex4.Models.Question", b =>
                {
                    b.Navigation("Answer")
                        .IsRequired();
                });

            modelBuilder.Entity("ex4.Models.Quiz", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ex4.Models.Student", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("ex4.Models.Teacher", b =>
                {
                    b.Navigation("Disciplines");
                });

            modelBuilder.Entity("ex4.Models.User", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();

                    b.Navigation("Teacher")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

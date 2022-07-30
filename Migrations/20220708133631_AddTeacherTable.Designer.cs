﻿// <auto-generated />
using System;
using ADHD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ADHD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220708133631_AddTeacherTable")]
    partial class AddTeacherTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ADHD.Models.Consultant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ConsuktantResume")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ConsultantProfiler")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ConsultantType")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PatientCount")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("RatingCount")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationDocument")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegistrationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Consultants");
                });

            modelBuilder.Entity("ADHD.Models.consultant.ConsultantRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("ADHD.Models.consultant.ConsultantSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("SessionRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.HasIndex("SessionId");

                    b.ToTable("ConsultantSession");
                });

            modelBuilder.Entity("ADHD.Models.consultant.FieldExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.ToTable("ExperienceInField");
                });

            modelBuilder.Entity("ADHD.Models.consultant.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ConsultantId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Institute")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ConsultantId");

                    b.ToTable("FieldOfStudy");
                });

            modelBuilder.Entity("ADHD.Models.consultant.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("Shift")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("ADHD.Models.DailyMood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mood")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DailyMoods");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Disorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Disorders");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.QuestionOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OptionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OptionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOption");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Symptom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DisorderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DisorderId");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.SymptomQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuestionOptionsId")
                        .HasColumnType("int");

                    b.Property<int>("SymptomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionOptionsId");

                    b.HasIndex("SymptomId");

                    b.ToTable("SymptomQuestions");
                });

            modelBuilder.Entity("ADHD.Models.MoodJournal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Anger")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("Fear")
                        .HasColumnType("float");

                    b.Property<float>("Joy")
                        .HasColumnType("float");

                    b.Property<float>("Love")
                        .HasColumnType("float");

                    b.Property<string>("Mood")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Sadness")
                        .HasColumnType("float");

                    b.Property<float>("Surprise")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MoodJournals");
                });

            modelBuilder.Entity("ADHD.Models.Story", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Stories");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NIC")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.TeacherClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherClasses");
                });

            modelBuilder.Entity("ADHD.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("isStudent")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("isVerified")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ADHD.Models.Consultant", b =>
                {
                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.consultant.ConsultantRating", b =>
                {
                    b.HasOne("ADHD.Models.Consultant", "Consultant")
                        .WithMany()
                        .HasForeignKey("ConsultantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.consultant.ConsultantSession", b =>
                {
                    b.HasOne("ADHD.Models.Consultant", "Consultant")
                        .WithMany()
                        .HasForeignKey("ConsultantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADHD.Models.consultant.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultant");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("ADHD.Models.consultant.FieldExperience", b =>
                {
                    b.HasOne("ADHD.Models.Consultant", null)
                        .WithMany("FieldOfExperience")
                        .HasForeignKey("ConsultantId");
                });

            modelBuilder.Entity("ADHD.Models.consultant.Qualification", b =>
                {
                    b.HasOne("ADHD.Models.Consultant", null)
                        .WithMany("Qualification")
                        .HasForeignKey("ConsultantId");
                });

            modelBuilder.Entity("ADHD.Models.DailyMood", b =>
                {
                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany("DailyMood")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.QuestionOption", b =>
                {
                    b.HasOne("ADHD.Models.Disorder.Option", "Option")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADHD.Models.Disorder.Question", "Question")
                        .WithMany("QuestionOptions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Symptom", b =>
                {
                    b.HasOne("ADHD.Models.Disorder.Disorder", null)
                        .WithMany("Symptoms")
                        .HasForeignKey("DisorderId");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.SymptomQuestion", b =>
                {
                    b.HasOne("ADHD.Models.Disorder.QuestionOption", "QuestionOptions")
                        .WithMany("SymptomQuestions")
                        .HasForeignKey("QuestionOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ADHD.Models.Disorder.Symptom", "Symptom")
                        .WithMany("SymptomQuestions")
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionOptions");

                    b.Navigation("Symptom");
                });

            modelBuilder.Entity("ADHD.Models.MoodJournal", b =>
                {
                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany("MoodJournal")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.Story", b =>
                {
                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany("Story")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.Teacher", b =>
                {
                    b.HasOne("ADHD.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.TeacherClass", b =>
                {
                    b.HasOne("ADHD.Models.Teacher.Class", null)
                        .WithMany("TeacherClass")
                        .HasForeignKey("ClassId");

                    b.HasOne("ADHD.Models.Teacher.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ADHD.Models.Consultant", b =>
                {
                    b.Navigation("FieldOfExperience");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Disorder", b =>
                {
                    b.Navigation("Symptoms");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Option", b =>
                {
                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Question", b =>
                {
                    b.Navigation("QuestionOptions");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.QuestionOption", b =>
                {
                    b.Navigation("SymptomQuestions");
                });

            modelBuilder.Entity("ADHD.Models.Disorder.Symptom", b =>
                {
                    b.Navigation("SymptomQuestions");
                });

            modelBuilder.Entity("ADHD.Models.Teacher.Class", b =>
                {
                    b.Navigation("TeacherClass");
                });

            modelBuilder.Entity("ADHD.Models.User", b =>
                {
                    b.Navigation("DailyMood");

                    b.Navigation("MoodJournal");

                    b.Navigation("Story");
                });
#pragma warning restore 612, 618
        }
    }
}

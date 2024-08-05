﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentPerformanceTracker.Data;

#nullable disable

namespace StudentPerformanceTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240805074344_InitialSetup")]
    partial class InitialSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentPerformanceTracker.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SessionId"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recurrence")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SessionId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            SessionId = 1,
                            EndTime = new DateTime(2024, 8, 5, 12, 13, 41, 828, DateTimeKind.Local).AddTicks(8036),
                            Recurrence = "One-off",
                            StartTime = new DateTime(2024, 8, 5, 11, 13, 41, 828, DateTimeKind.Local).AddTicks(8022),
                            Subject = "Math",
                            Type = "Study",
                            UserId = 1
                        },
                        new
                        {
                            SessionId = 2,
                            EndTime = new DateTime(2024, 8, 5, 10, 13, 41, 828, DateTimeKind.Local).AddTicks(8073),
                            Recurrence = "One-off",
                            StartTime = new DateTime(2024, 8, 5, 9, 13, 41, 828, DateTimeKind.Local).AddTicks(8072),
                            Subject = "Science",
                            Type = "Break",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("StudentPerformanceTracker.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "test@example.com",
                            Password = "password",
                            ProfileInfo = "Test user profile info",
                            Username = "testuser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

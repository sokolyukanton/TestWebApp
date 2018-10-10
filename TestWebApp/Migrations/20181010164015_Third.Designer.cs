﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestWebApp.Models;

namespace TestWebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181010164015_Third")]
    partial class Third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("TestWebApp.Models.Group", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new { Id = 1L, Name = "100" },
                        new { Id = 2L, Name = "200" }
                    );
                });

            modelBuilder.Entity("TestWebApp.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GroupId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");

                    b.HasData(
                        new { Id = 1L, GroupId = 1L, Name = "Bob" },
                        new { Id = 2L, GroupId = 1L, Name = "Bub" },
                        new { Id = 3L, GroupId = 2L, Name = "Beb" }
                    );
                });

            modelBuilder.Entity("TestWebApp.Models.Student", b =>
                {
                    b.HasOne("TestWebApp.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

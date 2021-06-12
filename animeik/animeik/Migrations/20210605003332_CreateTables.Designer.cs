﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using animeik.Data;

namespace animeik.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605003332_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("animeik.Models.Anime", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Categoryid")
                        .HasColumnType("int");

                    b.Property<string>("end_date")
                        .HasColumnType("text");

                    b.Property<int>("episodes")
                        .HasColumnType("int");

                    b.Property<string>("image_url")
                        .HasColumnType("text");

                    b.Property<double>("score")
                        .HasColumnType("double");

                    b.Property<string>("start_date")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("Animes");

                    b.HasData(
                        new
                        {
                            id = 2,
                            Categoryid = 2,
                            end_date = "2021",
                            episodes = 34,
                            image_url = "s",
                            score = 9.5,
                            start_date = "2002",
                            title = "onepiece",
                            type = "",
                            url = "www.examle.com"
                        },
                        new
                        {
                            id = 1,
                            Categoryid = 1,
                            end_date = "2021",
                            episodes = 23,
                            image_url = "e",
                            score = 6.5,
                            start_date = "2020",
                            title = "naruto",
                            type = "",
                            url = "www.examle.com"
                        },
                        new
                        {
                            id = 3,
                            Categoryid = 1,
                            end_date = "2021",
                            episodes = 12,
                            image_url = "a",
                            score = 10.5,
                            start_date = "2004",
                            title = "attack on titan",
                            type = "",
                            url = "www.examle.com"
                        });
                });

            modelBuilder.Entity("animeik.Models.Category", b =>
                {
                    b.Property<int>("Categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Categoryid");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Categoryid = 1,
                            Name = "action"
                        },
                        new
                        {
                            Categoryid = 2,
                            Name = "romance"
                        });
                });

            modelBuilder.Entity("animeik.Models.Faviorts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnimeIdid")
                        .HasColumnType("int");

                    b.Property<int>("UserIdid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AnimeIdid");

                    b.HasIndex("UserIdid");

                    b.ToTable("Faviortes");

                    b.HasData(
                        new
                        {
                            id = 1,
                            AnimeIdid = 1,
                            UserIdid = 1
                        },
                        new
                        {
                            id = 2,
                            AnimeIdid = 1,
                            UserIdid = 2
                        });
                });

            modelBuilder.Entity("animeik.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 2,
                            username = "eren"
                        },
                        new
                        {
                            id = 1,
                            username = "hassan"
                        });
                });

            modelBuilder.Entity("animeik.Models.Anime", b =>
                {
                    b.HasOne("animeik.Models.Category", null)
                        .WithMany("Animes")
                        .HasForeignKey("Categoryid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("animeik.Models.Faviorts", b =>
                {
                    b.HasOne("animeik.Models.Anime", "AnimeId")
                        .WithMany()
                        .HasForeignKey("AnimeIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("animeik.Models.User", "UserId")
                        .WithMany()
                        .HasForeignKey("UserIdid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

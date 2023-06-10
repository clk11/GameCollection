﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MvcVideoGame.Migrations
{
    [DbContext(typeof(MvcVideoGameContext))]
    partial class MvcVideoGameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("MvcVideoGame.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("MvcVideoGame.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Developer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Multiplayer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Platform")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VideoGame");
                });

            modelBuilder.Entity("MvcVideoGame.Models.Review", b =>
                {
                    b.HasOne("MvcVideoGame.Models.VideoGame", "VideoGame")
                        .WithMany("Reviews")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("MvcVideoGame.Models.VideoGame", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

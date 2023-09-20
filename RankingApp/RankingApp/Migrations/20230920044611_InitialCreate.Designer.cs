﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RankingApp.Models;

#nullable disable

namespace RankingApp.Migrations
{
    [DbContext(typeof(RankingContext))]
    [Migration("20230920044611_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("RankingApp.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ranking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RankingsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ItemList");
                });
#pragma warning restore 612, 618
        }
    }
}

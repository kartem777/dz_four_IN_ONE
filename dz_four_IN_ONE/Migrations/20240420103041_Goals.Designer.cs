﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dz_four_IN_ONE;

#nullable disable

namespace dz_four_IN_ONE.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240420103041_Goals")]
    partial class Goals
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("dz_four_IN_ONE.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DrawCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsLose")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsWin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LoseCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WinCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tournament");
                });
#pragma warning restore 612, 618
        }
    }
}

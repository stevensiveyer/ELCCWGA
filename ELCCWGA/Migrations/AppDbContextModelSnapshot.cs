﻿// <auto-generated />
using System;
using ELCCWGA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELCCWGA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WGA.GolfScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Creek1")
                        .HasColumnType("int");

                    b.Property<int>("Creek2")
                        .HasColumnType("int");

                    b.Property<int>("Creek3")
                        .HasColumnType("int");

                    b.Property<int>("Creek4")
                        .HasColumnType("int");

                    b.Property<int>("Creek5")
                        .HasColumnType("int");

                    b.Property<int>("Creek6")
                        .HasColumnType("int");

                    b.Property<int>("Creek7")
                        .HasColumnType("int");

                    b.Property<int>("Creek8")
                        .HasColumnType("int");

                    b.Property<int>("Creek9")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Hill1")
                        .HasColumnType("int");

                    b.Property<int>("Hill2")
                        .HasColumnType("int");

                    b.Property<int>("Hill3")
                        .HasColumnType("int");

                    b.Property<int>("Hill4")
                        .HasColumnType("int");

                    b.Property<int>("Hill5")
                        .HasColumnType("int");

                    b.Property<int>("Hill6")
                        .HasColumnType("int");

                    b.Property<int>("Hill7")
                        .HasColumnType("int");

                    b.Property<int>("Hill8")
                        .HasColumnType("int");

                    b.Property<int>("Hill9")
                        .HasColumnType("int");

                    b.Property<int>("Lake1")
                        .HasColumnType("int");

                    b.Property<int>("Lake2")
                        .HasColumnType("int");

                    b.Property<int>("Lake3")
                        .HasColumnType("int");

                    b.Property<int>("Lake4")
                        .HasColumnType("int");

                    b.Property<int>("Lake5")
                        .HasColumnType("int");

                    b.Property<int>("Lake6")
                        .HasColumnType("int");

                    b.Property<int>("Lake7")
                        .HasColumnType("int");

                    b.Property<int>("Lake8")
                        .HasColumnType("int");

                    b.Property<int>("Lake9")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Tee")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}

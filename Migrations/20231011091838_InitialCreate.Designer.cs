﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


#nullable disable

namespace webAPIMiniReddit.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231011091838_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("webAPIMiniReddit.Model.Kommentar", b =>
                {
                    b.Property<int>("idKommentar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("brugerKommentar")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dato")
                        .HasColumnType("TEXT");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idKommentar");

                    b.ToTable("Kommentare", (string)null);
                });

            modelBuilder.Entity("webAPIMiniReddit.Model.Traad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("beskrivelse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("brugerTraad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("kommentar")
                        .HasColumnType("TEXT");

                    b.Property<int>("stem")
                        .HasColumnType("INTEGER");

                    b.Property<string>("titel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("totalStemmer")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Traade", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

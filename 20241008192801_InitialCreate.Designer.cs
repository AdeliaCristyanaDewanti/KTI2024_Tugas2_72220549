﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleSecureWeb.Data;

#nullable disable

namespace SampleSecureWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241008192801_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("SampleSecureWeb.Models.Student", b =>
                {
                    b.Property<string>("Nim")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Nim");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}

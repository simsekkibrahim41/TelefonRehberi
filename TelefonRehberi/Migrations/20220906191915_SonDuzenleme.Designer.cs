﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelefonRehberi.Models;

#nullable disable

namespace TelefonRehberi.Migrations
{
    [DbContext(typeof(TelefonRehberiContext))]
    [Migration("20220906191915_SonDuzenleme")]
    partial class SonDuzenleme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TelefonRehberi.Models.Rehber", b =>
                {
                    b.Property<int>("RehberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RehberId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("E_Mail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Fax_Numarasi")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Telefon_Numarasi")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.HasKey("RehberId");

                    b.ToTable("TelefonRehberleri");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Kurs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kurs.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Kurs.Data.Models.Level", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("Kurs.Data.Models.Theme", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("levelID")
                        .HasColumnType("int");

                    b.Property<string>("longDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("levelID");

                    b.ToTable("Theme");
                });

            modelBuilder.Entity("Kurs.Data.Models.Theme", b =>
                {
                    b.HasOne("Kurs.Data.Models.Level", "level")
                        .WithMany("Themes")
                        .HasForeignKey("levelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("level");
                });

            modelBuilder.Entity("Kurs.Data.Models.Level", b =>
                {
                    b.Navigation("Themes");
                });
#pragma warning restore 612, 618
        }
    }
}

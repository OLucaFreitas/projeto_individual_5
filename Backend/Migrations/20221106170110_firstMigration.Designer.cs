﻿// <auto-generated />
using GoodTravel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodTravel.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221106170110_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GoodTravel.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.Property<string>("dataIda")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("dataVolta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("destinos");
                });

            modelBuilder.Entity("GoodTravel.Model.Promocao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("destino_fk")
                        .HasColumnType("int");

                    b.Property<double>("valorPromo")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("destino_fk");

                    b.ToTable("promocoes");
                });

            modelBuilder.Entity("GoodTravel.Model.Promocao", b =>
                {
                    b.HasOne("GoodTravel.Model.Destino", "Destino")
                        .WithMany("Promocoes")
                        .HasForeignKey("destino_fk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");
                });

            modelBuilder.Entity("GoodTravel.Model.Destino", b =>
                {
                    b.Navigation("Promocoes");
                });
#pragma warning restore 612, 618
        }
    }
}

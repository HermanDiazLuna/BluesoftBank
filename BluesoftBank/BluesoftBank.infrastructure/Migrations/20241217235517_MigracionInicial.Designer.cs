﻿// <auto-generated />
using BluesoftBank.infrastructure.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BluesoftBank.infrastructure.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20241217235517_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BluesoftBank.core.entidades.TipoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipo_cliente", (string)null);
                });

            modelBuilder.Entity("BluesoftBank.core.entidades.TipoCuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipo_cuenta", (string)null);
                });

            modelBuilder.Entity("BluesoftBank.core.entidades.TipoMovimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("descripcion");

                    b.HasKey("Id");

                    b.ToTable("tipo_movimiento", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

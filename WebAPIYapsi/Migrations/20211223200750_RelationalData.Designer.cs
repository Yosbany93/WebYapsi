﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIYapsi;

namespace WebAPIYapsi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211223200750_RelationalData")]
    partial class RelationalData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPIYapsi.Entities.Movimientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("EsIngreso")
                        .HasColumnType("bit");

                    b.Property<int>("IdSocio")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoMovimiento")
                        .HasColumnType("int");

                    b.Property<int?>("SocioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocioId");

                    b.ToTable("Movimientos");
                });

            modelBuilder.Entity("WebAPIYapsi.Entities.Socio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SaldoTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("WebAPIYapsi.Entities.TipoMovimientos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoMovimiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoMovimientos");
                });

            modelBuilder.Entity("WebAPIYapsi.Entities.Movimientos", b =>
                {
                    b.HasOne("WebAPIYapsi.Entities.Socio", "Socio")
                        .WithMany("Movimientos")
                        .HasForeignKey("SocioId");

                    b.Navigation("Socio");
                });

            modelBuilder.Entity("WebAPIYapsi.Entities.Socio", b =>
                {
                    b.Navigation("Movimientos");
                });
#pragma warning restore 612, 618
        }
    }
}

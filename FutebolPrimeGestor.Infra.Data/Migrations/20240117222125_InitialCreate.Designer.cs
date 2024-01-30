﻿// <auto-generated />
using System;
using FutebolPrimeGestor.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FutebolPrimeGestor.Infra.Data.Migrations
{
    [DbContext(typeof(FutebolPrimeGestorDbContext))]
    [Migration("20240117222125_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.AluguelDeQuadra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FimAluguel")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCliente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdQuadra")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("InicioAluguel")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ValorFinalAluguel")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdQuadra");

                    b.ToTable("AlugueisDeQuadras", (string)null);
                });

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("CHAR(11)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("CHAR(11)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .HasDatabaseName("idx_cliente_cpf");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.Quadra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioFimFuncionamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicioFuncionamento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("TipoQuadra")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Quadras", (string)null);
                });

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.AluguelDeQuadra", b =>
                {
                    b.HasOne("FutebolPrimeGestor.Domain.Entities.Cliente", "Cliente")
                        .WithMany("AlugueisDeQuadras")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FutebolPrimeGestor.Domain.Entities.Quadra", "Quadra")
                        .WithMany("AlugueisDeQuadras")
                        .HasForeignKey("IdQuadra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Quadra");
                });

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("AlugueisDeQuadras");
                });

            modelBuilder.Entity("FutebolPrimeGestor.Domain.Entities.Quadra", b =>
                {
                    b.Navigation("AlugueisDeQuadras");
                });
#pragma warning restore 612, 618
        }
    }
}
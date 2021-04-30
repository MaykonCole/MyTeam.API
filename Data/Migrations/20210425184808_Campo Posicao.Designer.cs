﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210425184808_Campo Posicao")]
    partial class CampoPosicao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("PerfilPlayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PlayerAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("Psn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Celular = "31993712719",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 400, DateTimeKind.Local).AddTicks(247),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 400, DateTimeKind.Local).AddTicks(3502),
                            DataNascimento = new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Maykon",
                            Numero = 13,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = false,
                            Psn = "Maykon1993",
                            TimeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Celular = "11978653211",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3295),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3461),
                            DataNascimento = new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Samuel",
                            Numero = 7,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = true,
                            Psn = "santacruzpe",
                            TimeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Celular = "44967543245",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3632),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3654),
                            DataNascimento = new DateTime(1989, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Celio",
                            Numero = 9,
                            PerfilPlayer = "DT",
                            PlayerAtivo = true,
                            Psn = "Celio_Shadow_14",
                            TimeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Celular = "31993122719",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3659),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3671),
                            DataNascimento = new DateTime(1978, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Jose",
                            Numero = 5,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = true,
                            Psn = "joselito1970",
                            TimeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Celular = "11978653211",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3675),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3684),
                            DataNascimento = new DateTime(1990, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Mauricio",
                            Numero = 6,
                            PerfilPlayer = "DT",
                            PlayerAtivo = true,
                            Psn = "maumau",
                            TimeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Celular = "44967542145",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3697),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3710),
                            DataNascimento = new DateTime(1980, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Fernando",
                            Numero = 10,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = false,
                            Psn = "fernando123",
                            TimeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Celular = "31993154719",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3713),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3722),
                            DataNascimento = new DateTime(1994, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Adam",
                            Numero = 2,
                            PerfilPlayer = "DT",
                            PlayerAtivo = true,
                            Psn = "adao",
                            TimeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Celular = "11978113211",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3725),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3734),
                            DataNascimento = new DateTime(1998, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Emerson",
                            Numero = 8,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = false,
                            Psn = "emer",
                            TimeId = 3
                        },
                        new
                        {
                            Id = 9,
                            Celular = "44961242145",
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3737),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3746),
                            DataNascimento = new DateTime(1988, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Jullius",
                            Numero = 3,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = true,
                            Psn = "cachaca",
                            TimeId = 3
                        });
                });

            modelBuilder.Entity("Dominio.Models.PlayerApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcuraTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Psn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeId");

                    b.ToTable("PlayersApp");
                });

            modelBuilder.Entity("Dominio.Models.PlayerPosicao", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PosicaoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.HasKey("PlayerId", "PosicaoId");

                    b.HasIndex("PosicaoId");

                    b.ToTable("PlayersPosicoes");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            PosicaoId = 7,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(6830)
                        },
                        new
                        {
                            PlayerId = 1,
                            PosicaoId = 5,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8729)
                        },
                        new
                        {
                            PlayerId = 2,
                            PosicaoId = 6,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8771)
                        },
                        new
                        {
                            PlayerId = 3,
                            PosicaoId = 11,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8774)
                        },
                        new
                        {
                            PlayerId = 4,
                            PosicaoId = 3,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8777)
                        },
                        new
                        {
                            PlayerId = 5,
                            PosicaoId = 2,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8784)
                        },
                        new
                        {
                            PlayerId = 6,
                            PosicaoId = 5,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8787)
                        },
                        new
                        {
                            PlayerId = 7,
                            PosicaoId = 9,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8789)
                        },
                        new
                        {
                            PlayerId = 8,
                            PosicaoId = 10,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8792)
                        },
                        new
                        {
                            PlayerId = 9,
                            PosicaoId = 1,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8796)
                        },
                        new
                        {
                            PlayerId = 2,
                            PosicaoId = 7,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8798)
                        },
                        new
                        {
                            PlayerId = 3,
                            PosicaoId = 7,
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8801)
                        });
                });

            modelBuilder.Entity("Dominio.Models.Posicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAbreviado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePosicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PosicaoAtiva")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Posicoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomePosicao = "GOL",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 2,
                            NomePosicao = "LD",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 3,
                            NomePosicao = "ZC",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 4,
                            NomePosicao = "LE",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 5,
                            NomePosicao = "VOL",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 6,
                            NomePosicao = "MLG",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 7,
                            NomePosicao = "MAT",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 8,
                            NomePosicao = "PTE",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 9,
                            NomePosicao = "PTD",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 10,
                            NomePosicao = "SA",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 11,
                            NomePosicao = "CA",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 12,
                            NomePosicao = "ALD",
                            PosicaoAtiva = false
                        },
                        new
                        {
                            Id = 13,
                            NomePosicao = "ALE",
                            PosicaoAtiva = false
                        });
                });

            modelBuilder.Entity("Dominio.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkEscudo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TimeAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Times");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 395, DateTimeKind.Local).AddTicks(3544),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(2103),
                            DataFundacao = new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.huntersx.jpg",
                            NomeTime = "Huntersx",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8692),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8828),
                            DataFundacao = new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.bleuz.jpg",
                            NomeTime = "Bleuz",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8924),
                            DataCadastro = new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8950),
                            DataFundacao = new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.mastermaq.jpg",
                            NomeTime = "Mastermaq",
                            TimeAtivo = false
                        });
                });

            modelBuilder.Entity("Dominio.Models.Player", b =>
                {
                    b.HasOne("Dominio.Models.Time", "Time")
                        .WithMany("Players")
                        .HasForeignKey("TimeId");
                });

            modelBuilder.Entity("Dominio.Models.PlayerApp", b =>
                {
                    b.HasOne("Dominio.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId");
                });

            modelBuilder.Entity("Dominio.Models.PlayerPosicao", b =>
                {
                    b.HasOne("Dominio.Models.Player", "Player")
                        .WithMany("PlayerPosicoes")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Models.Posicao", "Posicao")
                        .WithMany("PlayerPosicoes")
                        .HasForeignKey("PosicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

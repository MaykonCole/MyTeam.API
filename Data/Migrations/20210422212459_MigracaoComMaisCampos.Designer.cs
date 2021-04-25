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
    [Migration("20210422212459_MigracaoComMaisCampos")]
    partial class MigracaoComMaisCampos
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

                    b.Property<DateTime?>("DataNascimento")
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(8287),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 364, DateTimeKind.Local).AddTicks(1882),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4219),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4411),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4595),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4620),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4625),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4636),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4641),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4651),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4666),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4678),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4681),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4690),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4693),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4701),
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4707),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4715),
                            DataNascimento = new DateTime(1988, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Jullius",
                            Numero = 3,
                            PerfilPlayer = "Jogador",
                            PlayerAtivo = true,
                            Psn = "cachaca",
                            TimeId = 3
                        });
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
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(8704)
                        },
                        new
                        {
                            PlayerId = 1,
                            PosicaoId = 5,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(892)
                        },
                        new
                        {
                            PlayerId = 2,
                            PosicaoId = 6,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(933)
                        },
                        new
                        {
                            PlayerId = 3,
                            PosicaoId = 11,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(936)
                        },
                        new
                        {
                            PlayerId = 4,
                            PosicaoId = 3,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(939)
                        },
                        new
                        {
                            PlayerId = 5,
                            PosicaoId = 2,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(952)
                        },
                        new
                        {
                            PlayerId = 6,
                            PosicaoId = 5,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(955)
                        },
                        new
                        {
                            PlayerId = 7,
                            PosicaoId = 9,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(957)
                        },
                        new
                        {
                            PlayerId = 8,
                            PosicaoId = 10,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(960)
                        },
                        new
                        {
                            PlayerId = 9,
                            PosicaoId = 1,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(965)
                        },
                        new
                        {
                            PlayerId = 2,
                            PosicaoId = 7,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(967)
                        },
                        new
                        {
                            PlayerId = 3,
                            PosicaoId = 7,
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(969)
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
                            NomePosicao = "Goleiro",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 2,
                            NomePosicao = "Lateral Direito",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 3,
                            NomePosicao = "Zagueiro",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 4,
                            NomePosicao = "Lateral Esquerdo",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 5,
                            NomePosicao = "Volante",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 6,
                            NomePosicao = "Meia Ligação",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 7,
                            NomePosicao = "Meia Atacante",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 8,
                            NomePosicao = "Ponta Esquerda",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 9,
                            NomePosicao = "Ponta Direita",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 10,
                            NomePosicao = "Segundo Atacante",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 11,
                            NomePosicao = "Centro Avante",
                            PosicaoAtiva = true
                        },
                        new
                        {
                            Id = 12,
                            NomePosicao = "Ala Direito",
                            PosicaoAtiva = false
                        },
                        new
                        {
                            Id = 13,
                            NomePosicao = "Ala Esquerdo",
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
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 357, DateTimeKind.Local).AddTicks(2773),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 362, DateTimeKind.Local).AddTicks(9865),
                            DataFundacao = new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.huntersx.jpg",
                            NomeTime = "Huntersx",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6682),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6847),
                            DataFundacao = new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.bleuz.jpg",
                            NomeTime = "Bleuz",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6947),
                            DataCadastro = new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6971),
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
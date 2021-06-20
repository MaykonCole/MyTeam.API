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
    [Migration("20210502150818_campotelefone")]
    partial class campotelefone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("adversario")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("dtAdversario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dtCadastro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("horario")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("psnAdversario")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("telefoneAdversario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoJogo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeamId = 1,
                            adversario = "Tombense",
                            data = "03-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5729),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5745),
                            dtAdversario = "Zezinho",
                            dtCadastro = "Maykon",
                            horario = "16:30",
                            psnAdversario = "tomtom",
                            telefoneAdversario = "31956785421",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 2,
                            TeamId = 1,
                            adversario = "America",
                            data = "02-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6129),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6132),
                            dtAdversario = "Lisca",
                            dtCadastro = "Isabela",
                            horario = "22:00",
                            psnAdversario = "liscadoid",
                            telefoneAdversario = "31956784321",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 3,
                            TeamId = 1,
                            adversario = "Cruzeiro",
                            data = "02-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6368),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6370),
                            dtAdversario = "Felipe",
                            dtCadastro = "Ramiro",
                            horario = "16:00",
                            psnAdversario = "conception",
                            telefoneAdversario = "38991081254",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 4,
                            TeamId = 2,
                            adversario = "Tombense",
                            data = "06-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6395),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6397),
                            dtAdversario = "Zezinho",
                            dtCadastro = "Maykon",
                            horario = "16:30",
                            psnAdversario = "tomtom",
                            telefoneAdversario = "31956785421",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 5,
                            TeamId = 2,
                            adversario = "America",
                            data = "04-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6419),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6421),
                            dtAdversario = "Lisca",
                            dtCadastro = "Isabela",
                            horario = "22:00",
                            psnAdversario = "liscadoid",
                            telefoneAdversario = "31956784321",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 6,
                            TeamId = 2,
                            adversario = "Cruzeiro",
                            data = "04-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6456),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6458),
                            dtAdversario = "Felipe",
                            dtCadastro = "Ramiro",
                            horario = "16:00",
                            psnAdversario = "conception",
                            telefoneAdversario = "38991081254",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 7,
                            TeamId = 3,
                            adversario = "Tombense",
                            data = "03-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6480),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6482),
                            dtAdversario = "Zezinho",
                            dtCadastro = "Maykon",
                            horario = "16:30",
                            psnAdversario = "tomtom",
                            telefoneAdversario = "31956785421",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 8,
                            TeamId = 3,
                            adversario = "America",
                            data = "05-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6505),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6507),
                            dtAdversario = "Lisca",
                            dtCadastro = "Isabela",
                            horario = "22:00",
                            psnAdversario = "liscadoid",
                            telefoneAdversario = "31956784321",
                            tipoJogo = "Camp. Mineiro"
                        },
                        new
                        {
                            Id = 9,
                            TeamId = 3,
                            adversario = "Cruzeiro",
                            data = "05-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6530),
                            dataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6532),
                            dtAdversario = "Felipe",
                            dtCadastro = "Ramiro",
                            horario = "16:00",
                            psnAdversario = "conception",
                            telefoneAdversario = "38991081254",
                            tipoJogo = "Camp. Mineiro"
                        });
                });

            modelBuilder.Entity("Dominio.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("PerfilPlayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PlayerAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("PosicaoA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosicaoP")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Psn")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Dominio.Models.PlayerApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Posicao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcuraTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Psn")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("PlayersApp");
                });

            modelBuilder.Entity("Dominio.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFundacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("LinkEscudo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("TimeAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Times");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 64, DateTimeKind.Local).AddTicks(8587),
                            DataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 70, DateTimeKind.Local).AddTicks(3937),
                            DataFundacao = new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.huntersx.jpg",
                            NomeTime = "Huntersx",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(718),
                            DataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(903),
                            DataFundacao = new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.bleuz.jpg",
                            NomeTime = "Bleuz",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1021),
                            DataCadastro = new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1045),
                            DataFundacao = new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LinkEscudo = "link.mastermaq.jpg",
                            NomeTime = "Mastermaq",
                            TimeAtivo = false
                        });
                });

            modelBuilder.Entity("Dominio.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PerfilUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dominio.Models.Game", b =>
                {
                    b.HasOne("Dominio.Models.Team", "Team")
                        .WithMany("Games")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dominio.Models.Player", b =>
                {
                    b.HasOne("Dominio.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("Dominio.Models.User", b =>
                {
                    b.HasOne("Dominio.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}
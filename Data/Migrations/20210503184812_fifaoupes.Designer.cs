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
    [Migration("20210503184812_fifaoupes")]
    partial class fifaoupes
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
                            data = "04-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 268, DateTimeKind.Local).AddTicks(9249),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 268, DateTimeKind.Local).AddTicks(9263),
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
                            data = "03-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1264),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1269),
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
                            data = "03-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1542),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1545),
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
                            data = "07-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1579),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1582),
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
                            data = "05-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1615),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1619),
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
                            data = "05-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1665),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1669),
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
                            data = "04-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1706),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1709),
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
                            data = "06-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1742),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1745),
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
                            data = "06-05-2021",
                            dataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1779),
                            dataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1782),
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

                    b.Property<bool>("GamePes")
                        .HasColumnType("bit");

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
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 257, DateTimeKind.Local).AddTicks(5484),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 264, DateTimeKind.Local).AddTicks(5228),
                            DataFundacao = new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GamePes = true,
                            LinkEscudo = "link.huntersx.jpg",
                            NomeTime = "Huntersx",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3445),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3679),
                            DataFundacao = new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GamePes = false,
                            LinkEscudo = "link.bleuz.jpg",
                            NomeTime = "Bleuz",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3780),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3805),
                            DataFundacao = new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GamePes = true,
                            LinkEscudo = "link.mastermaq.jpg",
                            NomeTime = "Mastermaq",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 4,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3811),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3825),
                            DataFundacao = new DateTime(1924, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GamePes = false,
                            LinkEscudo = "cruzeirocaiu.jpg",
                            NomeTime = "Cruzeiro",
                            TimeAtivo = true
                        },
                        new
                        {
                            Id = 5,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3831),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3843),
                            DataFundacao = new DateTime(1908, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GamePes = true,
                            LinkEscudo = "galaodamassa.jpg",
                            NomeTime = "Atletico",
                            TimeAtivo = true
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Login")
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(7505),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(7473),
                            Email = "maykontaiorpm@gmail.com",
                            Login = "Maykon1993",
                            Senha = "teste@123"
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4016),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(3987),
                            Email = "belbelm@gmail.com",
                            Login = "belcastroic",
                            Senha = "teste@123"
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4101),
                            DataCadastro = new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4096),
                            Email = "santacruz@gmail.com",
                            Login = "santacruzpe451",
                            Senha = "teste@123"
                        });
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

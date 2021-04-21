using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MigracaoComCargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posicoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePosicao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTime = table.Column<string>(nullable: true),
                    LinkEscudo = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Psn = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    TimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Times_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayersPosicoes",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    PosicaoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersPosicoes", x => new { x.PlayerId, x.PosicaoId });
                    table.ForeignKey(
                        name: "FK_PlayersPosicoes_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayersPosicoes_Posicoes_PosicaoId",
                        column: x => x.PosicaoId,
                        principalTable: "Posicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posicoes",
                columns: new[] { "Id", "NomePosicao" },
                values: new object[,]
                {
                    { 1, "Goleiro" },
                    { 2, "Lateral Direito" },
                    { 3, "Zagueiro" },
                    { 4, "Lateral Esquerdo" },
                    { 5, "Volante" },
                    { 6, "Meia Ligação" },
                    { 7, "Meia Atacante" },
                    { 8, "Ponta Esquerda" },
                    { 9, "Ponta Direita" },
                    { 10, "Segundo Atacante" },
                    { 11, "Centro Avante" }
                });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Id", "DataAtualizacao", "DataCadastro", "LinkEscudo", "NomeTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 20, 21, 11, 52, 754, DateTimeKind.Local).AddTicks(8903), new DateTime(2021, 4, 20, 21, 11, 52, 752, DateTimeKind.Local).AddTicks(6465), "link.huntersx.jpg", "Huntersx" },
                    { 2, new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5775), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5746), "link.bleuz.jpg", "Bleuz" },
                    { 3, new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5897), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5895), "link.mastermaq.jpg", "Mastermaq" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Celular", "DataAtualizacao", "DataCadastro", "Nome", "Numero", "Psn", "TimeId" },
                values: new object[,]
                {
                    { 1, "31993712719", new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(7540), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(7525), "Maykon", 13, "Maykon1993", 1 },
                    { 2, "11978653211", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(6674), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(6641), "Samuel", 7, "santacruzpe", 1 },
                    { 3, "44967543245", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7170), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7157), "Celio", 9, "Celio_Shadow_14", 1 },
                    { 4, "31993122719", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7197), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7189), "Jose", 5, "joselito1970", 2 },
                    { 5, "11978653211", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7219), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7210), "Mauricio", 6, "maumau", 2 },
                    { 6, "44967542145", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7259), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7250), "Fernando", 10, "fernando123", 2 },
                    { 7, "31993154719", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7280), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7272), "Adam", 2, "adao", 3 },
                    { 8, "11978113211", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7300), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7293), "Emerson", 8, "emer", 3 },
                    { 9, "44961242145", new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7321), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7313), "Jullius", 3, "cachaca", 3 }
                });

            migrationBuilder.InsertData(
                table: "PlayersPosicoes",
                columns: new[] { "PlayerId", "PosicaoId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 3, 11 },
                    { 3, 7 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 5 },
                    { 7, 9 },
                    { 8, 10 },
                    { 9, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TimeId",
                table: "Players",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersPosicoes_PosicaoId",
                table: "PlayersPosicoes",
                column: "PosicaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersPosicoes");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Posicoes");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}

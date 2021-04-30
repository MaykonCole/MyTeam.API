using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SemPosicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayersPosicoes");

            migrationBuilder.DropTable(
                name: "Posicoes");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 318, DateTimeKind.Local).AddTicks(94), new DateTime(2021, 4, 26, 7, 56, 2, 318, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(3556), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4029), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4088), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4122), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4169), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4197), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4225), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4253), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 306, DateTimeKind.Local).AddTicks(6836), new DateTime(2021, 4, 26, 7, 56, 2, 314, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4156), new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4395), new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4418) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAbreviado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomePosicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicaoAtiva = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayersPosicoes",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PosicaoId = table.Column<int>(type: "int", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 400, DateTimeKind.Local).AddTicks(247), new DateTime(2021, 4, 25, 15, 48, 7, 400, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3295), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3632), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3659), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3675), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3697), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3713), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3725), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3737), new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.InsertData(
                table: "Posicoes",
                columns: new[] { "Id", "NomeAbreviado", "NomePosicao", "PosicaoAtiva" },
                values: new object[,]
                {
                    { 12, null, "ALD", false },
                    { 13, null, "ALE", false },
                    { 10, null, "SA", true },
                    { 9, null, "PTD", true },
                    { 8, null, "PTE", true },
                    { 7, null, "MAT", true },
                    { 6, null, "MLG", true },
                    { 5, null, "VOL", true },
                    { 4, null, "LE", true },
                    { 3, null, "ZC", true },
                    { 2, null, "LD", true },
                    { 11, null, "CA", true },
                    { 1, null, "GOL", true }
                });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 395, DateTimeKind.Local).AddTicks(3544), new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8692), new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8924), new DateTime(2021, 4, 25, 15, 48, 7, 399, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.InsertData(
                table: "PlayersPosicoes",
                columns: new[] { "PlayerId", "PosicaoId", "DataCadastro" },
                values: new object[,]
                {
                    { 9, 1, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8796) },
                    { 5, 2, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8784) },
                    { 4, 3, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8777) },
                    { 1, 5, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8729) },
                    { 6, 5, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8787) },
                    { 2, 6, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8771) },
                    { 1, 7, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(6830) },
                    { 2, 7, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8798) },
                    { 3, 7, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8801) },
                    { 7, 9, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8789) },
                    { 8, 10, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8792) },
                    { 3, 11, new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8774) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayersPosicoes_PosicaoId",
                table: "PlayersPosicoes",
                column: "PosicaoId");
        }
    }
}

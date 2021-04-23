using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class MigracaoComMaisCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataFundacao",
                table: "Times",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TimeAtivo",
                table: "Times",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NomeAbreviado",
                table: "Posicoes",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PosicaoAtiva",
                table: "Posicoes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "PlayersPosicoes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Players",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerfilPlayer",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PlayerAtivo",
                table: "Players",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(8287), new DateTime(2021, 4, 22, 18, 24, 58, 364, DateTimeKind.Local).AddTicks(1882), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", false });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4219), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4411), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4595), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4620), new DateTime(1989, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "DT", true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4625), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4636), new DateTime(1978, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4641), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4651), new DateTime(1990, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "DT", true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4666), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4678), new DateTime(1980, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", false });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4681), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4690), new DateTime(1994, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "DT", true });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4693), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4701), new DateTime(1998, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", false });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataNascimento", "PerfilPlayer", "PlayerAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4707), new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(4715), new DateTime(1988, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jogador", true });

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 365, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 6 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 11 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 4, 3 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 6, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 7, 9 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 8, 10 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 9, 1 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 22, 18, 24, 58, 366, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 1,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 2,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 3,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 4,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 5,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 6,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 7,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 8,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 9,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 10,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.UpdateData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 11,
                column: "PosicaoAtiva",
                value: true);

            migrationBuilder.InsertData(
                table: "Posicoes",
                columns: new[] { "Id", "NomeAbreviado", "NomePosicao", "PosicaoAtiva" },
                values: new object[,]
                {
                    { 13, null, "Ala Esquerdo", false },
                    { 12, null, "Ala Direito", false }
                });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataFundacao", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 357, DateTimeKind.Local).AddTicks(2773), new DateTime(2021, 4, 22, 18, 24, 58, 362, DateTimeKind.Local).AddTicks(9865), new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataFundacao", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6682), new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6847), new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "DataFundacao" },
                values: new object[] { new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6947), new DateTime(2021, 4, 22, 18, 24, 58, 363, DateTimeKind.Local).AddTicks(6971), new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posicoes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DropColumn(
                name: "DataFundacao",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "TimeAtivo",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "NomeAbreviado",
                table: "Posicoes");

            migrationBuilder.DropColumn(
                name: "PosicaoAtiva",
                table: "Posicoes");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "PlayersPosicoes");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PerfilPlayer",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerAtivo",
                table: "Players");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Players",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(7540), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(6674), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7170), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7197), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7219), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7259), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7280), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7300), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7321), new DateTime(2021, 4, 20, 21, 11, 52, 756, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 754, DateTimeKind.Local).AddTicks(8903), new DateTime(2021, 4, 20, 21, 11, 52, 752, DateTimeKind.Local).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5775), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5897), new DateTime(2021, 4, 20, 21, 11, 52, 755, DateTimeKind.Local).AddTicks(5895) });
        }
    }
}

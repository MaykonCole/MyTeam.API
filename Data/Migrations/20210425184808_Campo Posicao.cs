using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CampoPosicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Posicao",
                table: "PlayersApp",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 6 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 11 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 4, 3 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 6, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 7, 9 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 8, 10 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 9, 1 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 15, 48, 7, 401, DateTimeKind.Local).AddTicks(8796));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Posicao",
                table: "PlayersApp");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(3671), new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9460), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9836), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9863), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9877), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9901), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9917), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9929), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9942), new DateTime(2021, 4, 25, 12, 5, 14, 567, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 1, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 6 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 2, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 7 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 3, 11 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 4, 3 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 5, 2 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 6, 5 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 7, 9 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 8, 10 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "PlayersPosicoes",
                keyColumns: new[] { "PlayerId", "PosicaoId" },
                keyValues: new object[] { 9, 1 },
                column: "DataCadastro",
                value: new DateTime(2021, 4, 25, 12, 5, 14, 568, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 556, DateTimeKind.Local).AddTicks(9064), new DateTime(2021, 4, 25, 12, 5, 14, 565, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(1021), new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(1594), new DateTime(2021, 4, 25, 12, 5, 14, 566, DateTimeKind.Local).AddTicks(1656) });
        }
    }
}

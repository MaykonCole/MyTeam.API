using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FIFAORPES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GamePes",
                table: "Times",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 265, DateTimeKind.Local).AddTicks(4735), new DateTime(2021, 5, 3, 15, 46, 2, 265, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8462), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8733), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8769), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8802), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8850), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8854) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8883), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8916), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8949), new DateTime(2021, 5, 3, 15, 46, 2, 266, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 255, DateTimeKind.Local).AddTicks(34), new DateTime(2021, 5, 3, 15, 46, 2, 259, DateTimeKind.Local).AddTicks(6036), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(4871), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5073), true, false });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5161), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5187), true, true });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "Id", "DataAtualizacao", "DataCadastro", "DataFundacao", "GamePes", "LinkEscudo", "NomeTime", "TimeAtivo" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5213), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5224), new DateTime(1908, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "galaodamassa.jpg", "Atletico", true },
                    { 4, new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5193), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5207), new DateTime(1924, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "cruzeirocaiu.jpg", "Cruzeiro", false }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 267, DateTimeKind.Local).AddTicks(5063), new DateTime(2021, 5, 3, 15, 46, 2, 267, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 268, DateTimeKind.Local).AddTicks(554), new DateTime(2021, 5, 3, 15, 46, 2, 268, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 268, DateTimeKind.Local).AddTicks(643), new DateTime(2021, 5, 3, 15, 46, 2, 268, DateTimeKind.Local).AddTicks(638) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "GamePes",
                table: "Times");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 608, DateTimeKind.Local).AddTicks(2339), new DateTime(2021, 5, 3, 10, 22, 3, 608, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 609, DateTimeKind.Local).AddTicks(9669), new DateTime(2021, 5, 3, 10, 22, 3, 609, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(246), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(342), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(433), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(544), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(633), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(726), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 593, DateTimeKind.Local).AddTicks(5524), new DateTime(2021, 5, 3, 10, 22, 3, 602, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3525), new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3842), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3978), new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(4018), false });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(7528), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4201), new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4198) });
        }
    }
}

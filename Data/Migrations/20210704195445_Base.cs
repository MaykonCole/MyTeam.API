using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "TimeAtivo",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "dataAtualizacao",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "dataCadastro",
                table: "Games");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Times",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Times",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Times",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "Times",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "PlayersApp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "PlayersApp",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "PlayersApp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "PlayersApp",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Players",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Players",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Games",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AtualizadoEm",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CriadoEm",
                table: "Games",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExcluidoEm",
                table: "Games",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "data",
                value: "05-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "data",
                value: "04-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "data",
                value: "04-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "data",
                value: "08-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "data",
                value: "06-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "data",
                value: "06-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "data",
                value: "05-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "data",
                value: "07-07-2021");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "data",
                value: "07-07-2021");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "CriadoEm" },
                values: new object[] { true, new DateTime(2021, 7, 4, 16, 54, 44, 209, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "CriadoEm" },
                values: new object[] { true, new DateTime(2021, 7, 4, 16, 54, 44, 213, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "CriadoEm" },
                values: new object[] { true, new DateTime(2021, 7, 4, 16, 54, 44, 213, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "CriadoEm" },
                values: new object[] { true, new DateTime(2021, 7, 4, 16, 54, 44, 213, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "CriadoEm" },
                values: new object[] { true, new DateTime(2021, 7, 4, 16, 54, 44, 213, DateTimeKind.Local).AddTicks(9132) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "Times");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "PlayersApp");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "PlayersApp");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "PlayersApp");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "PlayersApp");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "AtualizadoEm",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CriadoEm",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ExcluidoEm",
                table: "Games");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Times",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Times",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "TimeAtivo",
                table: "Times",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Players",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Players",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataAtualizacao",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataCadastro",
                table: "Games",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "18-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 214, DateTimeKind.Local).AddTicks(6198), new DateTime(2021, 5, 17, 9, 34, 20, 214, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "17-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6120), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "17-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6265), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "21-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6289), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "19-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6311), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "19-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6340), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "18-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6363), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "20-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6385), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "20-05-2021", new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6406), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(9119), new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(86), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(291), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(308), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(322), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(345), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(358), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(372), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(385), new DateTime(2021, 5, 17, 9, 34, 20, 218, DateTimeKind.Local).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 203, DateTimeKind.Local).AddTicks(4447), new DateTime(2021, 5, 17, 9, 34, 20, 210, DateTimeKind.Local).AddTicks(3861), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2041), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2141), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2163), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2169), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2181), true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2186), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2196), true });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(9523), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4390), new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4461), new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4459) });
        }
    }
}

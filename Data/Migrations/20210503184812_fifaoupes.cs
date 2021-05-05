using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class fifaoupes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 268, DateTimeKind.Local).AddTicks(9249), new DateTime(2021, 5, 3, 15, 48, 11, 268, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1264), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1542), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1579), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1615), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1665), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1706), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1742), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 257, DateTimeKind.Local).AddTicks(5484), new DateTime(2021, 5, 3, 15, 48, 11, 264, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3679), false, true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3780), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3811), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3825), false, true });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3831), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(7505), new DateTime(2021, 5, 3, 15, 48, 11, 270, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4016), new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4101), new DateTime(2021, 5, 3, 15, 48, 11, 271, DateTimeKind.Local).AddTicks(4096) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 255, DateTimeKind.Local).AddTicks(34), new DateTime(2021, 5, 3, 15, 46, 2, 259, DateTimeKind.Local).AddTicks(6036) });

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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5161), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "GamePes", "TimeAtivo" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5193), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5207), true, false });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5213), new DateTime(2021, 5, 3, 15, 46, 2, 260, DateTimeKind.Local).AddTicks(5224) });

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassesComDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 248, DateTimeKind.Local).AddTicks(3002), new DateTime(2021, 5, 1, 14, 50, 48, 248, DateTimeKind.Local).AddTicks(5260), new DateTime(2021, 5, 1, 14, 50, 48, 248, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(1989), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2212), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2370), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2380), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2388), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2391), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2397), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2401), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2415), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2418), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2424), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2426), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2432), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2434), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2440), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2443), new DateTime(2021, 5, 1, 14, 50, 48, 249, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 241, DateTimeKind.Local).AddTicks(3345), new DateTime(2021, 5, 1, 14, 50, 48, 245, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 246, DateTimeKind.Local).AddTicks(1983), new DateTime(2021, 5, 1, 14, 50, 48, 246, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 50, 48, 246, DateTimeKind.Local).AddTicks(2209), new DateTime(2021, 5, 1, 14, 50, 48, 246, DateTimeKind.Local).AddTicks(2237) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(5210), new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(9761), new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4193), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4631), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5028), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5047), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5063), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5072), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5084), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5093), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5123), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5135), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5157), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5167), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5189), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5200), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5222), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5233), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 74, DateTimeKind.Local).AddTicks(3012), new DateTime(2021, 5, 1, 14, 47, 8, 98, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 99, DateTimeKind.Local).AddTicks(6262), new DateTime(2021, 5, 1, 14, 47, 8, 99, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 14, 47, 8, 99, DateTimeKind.Local).AddTicks(6740), new DateTime(2021, 5, 1, 14, 47, 8, 99, DateTimeKind.Local).AddTicks(6790) });
        }
    }
}

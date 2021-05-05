using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class GameDataString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "data",
                table: "Games",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 587, DateTimeKind.Local).AddTicks(1979), new DateTime(2021, 5, 2, 10, 25, 50, 587, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2184), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2347), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3850), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3913), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3963), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3990), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(4014), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021 10:25:50/5/2021", new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(4039), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 576, DateTimeKind.Local).AddTicks(8635), new DateTime(2021, 5, 2, 10, 25, 50, 582, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 583, DateTimeKind.Local).AddTicks(9015), new DateTime(2021, 5, 2, 10, 25, 50, 583, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 583, DateTimeKind.Local).AddTicks(9557), new DateTime(2021, 5, 2, 10, 25, 50, 583, DateTimeKind.Local).AddTicks(9602) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "data",
                table: "Games",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));

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
    }
}

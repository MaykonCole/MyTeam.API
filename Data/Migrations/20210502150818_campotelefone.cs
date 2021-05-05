using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class campotelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "PlayersApp",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5729), new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6129), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6368), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6395), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6419), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6456), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6480), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6505), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6530), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 64, DateTimeKind.Local).AddTicks(8587), new DateTime(2021, 5, 2, 12, 8, 17, 70, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(718), new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1021), new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1045) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "PlayersApp",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 870, DateTimeKind.Local).AddTicks(7423), new DateTime(2021, 5, 2, 10, 59, 12, 870, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2674), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2716), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2750), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2802), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2840), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2873), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2904), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 860, DateTimeKind.Local).AddTicks(3270), new DateTime(2021, 5, 2, 10, 59, 12, 865, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 865, DateTimeKind.Local).AddTicks(8347), new DateTime(2021, 5, 2, 10, 59, 12, 865, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 59, 12, 865, DateTimeKind.Local).AddTicks(8645), new DateTime(2021, 5, 2, 10, 59, 12, 865, DateTimeKind.Local).AddTicks(8670) });
        }
    }
}

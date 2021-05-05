using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class DataOnString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 319, DateTimeKind.Local).AddTicks(8673), new DateTime(2021, 5, 2, 10, 31, 13, 319, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(352), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(654), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3116), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3255), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3349), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3409), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3466), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021 10:31:13/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3856), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 306, DateTimeKind.Local).AddTicks(3678), new DateTime(2021, 5, 2, 10, 31, 13, 313, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 314, DateTimeKind.Local).AddTicks(8833), new DateTime(2021, 5, 2, 10, 31, 13, 314, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 31, 13, 314, DateTimeKind.Local).AddTicks(9335), new DateTime(2021, 5, 2, 10, 31, 13, 314, DateTimeKind.Local).AddTicks(9379) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 587, DateTimeKind.Local).AddTicks(1979), new DateTime(2021, 5, 2, 10, 25, 50, 587, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2184), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2347), new DateTime(2021, 5, 2, 10, 25, 50, 588, DateTimeKind.Local).AddTicks(2349) });

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
    }
}

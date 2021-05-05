using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Tracinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 870, DateTimeKind.Local).AddTicks(7423), new DateTime(2021, 5, 2, 10, 59, 12, 870, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2425), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2674), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2716), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2750), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2802), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2840), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2873), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2904), new DateTime(2021, 5, 2, 10, 59, 12, 872, DateTimeKind.Local).AddTicks(2907) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 667, DateTimeKind.Local).AddTicks(4454), new DateTime(2021, 5, 2, 10, 46, 45, 667, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(7982), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8247), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8290), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8330), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8383), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8424), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8463), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05/05/2021", new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8503), new DateTime(2021, 5, 2, 10, 46, 45, 668, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 46, 45, 655, DateTimeKind.Local).AddTicks(7796), new DateTime(2021, 5, 2, 10, 46, 45, 661, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 46, 45, 662, DateTimeKind.Local).AddTicks(7579), new DateTime(2021, 5, 2, 10, 46, 45, 662, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 10, 46, 45, 662, DateTimeKind.Local).AddTicks(7903), new DateTime(2021, 5, 2, 10, 46, 45, 662, DateTimeKind.Local).AddTicks(7941) });
        }
    }
}

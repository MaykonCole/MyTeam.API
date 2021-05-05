using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class DiaMesConvertido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 319, DateTimeKind.Local).AddTicks(8673), new DateTime(2021, 5, 2, 10, 31, 13, 319, DateTimeKind.Local).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(352), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "2/5/2021", new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(654), new DateTime(2021, 5, 2, 10, 31, 13, 322, DateTimeKind.Local).AddTicks(659) });

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
    }
}

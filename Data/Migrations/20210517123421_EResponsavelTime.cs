using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class EResponsavelTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ResponsavelTime",
                table: "Users",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 203, DateTimeKind.Local).AddTicks(4447), new DateTime(2021, 5, 17, 9, 34, 20, 210, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2141), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2169), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2186), new DateTime(2021, 5, 17, 9, 34, 20, 211, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "ResponsavelTime", "Senha" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(9523), new DateTime(2021, 5, 17, 9, 34, 20, 215, DateTimeKind.Local).AddTicks(9510), true, "123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Senha" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4390), new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4377), "123456" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Senha" },
                values: new object[] { new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4461), new DateTime(2021, 5, 17, 9, 34, 20, 216, DateTimeKind.Local).AddTicks(4459), "123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponsavelTime",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "15-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 705, DateTimeKind.Local).AddTicks(8297), new DateTime(2021, 5, 14, 16, 49, 0, 705, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "14-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8603), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "14-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8750), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "18-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8772), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "16-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8793), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "16-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8822), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "15-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8843), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "17-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8864), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "17-05-2021", new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8886), new DateTime(2021, 5, 14, 16, 49, 0, 706, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 708, DateTimeKind.Local).AddTicks(1247), new DateTime(2021, 5, 14, 16, 49, 0, 708, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2376), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2578), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2603), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2619), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2643), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2658), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2674), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2689), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 695, DateTimeKind.Local).AddTicks(1148), new DateTime(2021, 5, 14, 16, 49, 0, 701, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3249), new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3534), new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3565), new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3583), new DateTime(2021, 5, 14, 16, 49, 0, 702, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Senha" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(2463), "teste@123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Senha" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6356), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6343), "teste@123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Senha" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6404), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6402), "teste@123" });
        }
    }
}

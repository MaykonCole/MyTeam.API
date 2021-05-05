using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class campocelular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Players",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 376, DateTimeKind.Local).AddTicks(7205), new DateTime(2021, 5, 5, 11, 13, 56, 376, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(6977), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7139), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "09-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7164), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "07-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7187), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "07-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7225), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7246), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "08-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7267), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "08-05-2021", new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7289), new DateTime(2021, 5, 5, 11, 13, 56, 377, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(8974), new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9604), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9813), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9809), 99, "DT" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9835), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9832), 3, "DT" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9849), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9847), 4 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9873), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9870), 6 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9887), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9884), 2 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9900), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9898), 5, "DT" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9913), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9911), 9 });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 367, DateTimeKind.Local).AddTicks(6875), new DateTime(2021, 5, 5, 11, 13, 56, 372, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2450), new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2785), new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2814), new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2832), new DateTime(2021, 5, 5, 11, 13, 56, 373, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(702), new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(4572), new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(4642), new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(4639) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Players",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 190, DateTimeKind.Local).AddTicks(5003), new DateTime(2021, 5, 3, 16, 40, 26, 190, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5715), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5959), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "07-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5994), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6025), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6075), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6108), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6138), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6169), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 193, DateTimeKind.Local).AddTicks(3624), new DateTime(2021, 5, 3, 16, 40, 26, 193, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(302), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(523), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(520), 7, "Jogador" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(544), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(542), 7, "Jogador" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(558), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(556), 7 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(582), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(580), 7 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(595), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(593), 7 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero", "PerfilPlayer" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(608), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(606), 7, "Jogador" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro", "Numero" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(621), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(619), 7 });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 180, DateTimeKind.Local).AddTicks(3404), new DateTime(2021, 5, 3, 16, 40, 26, 186, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 186, DateTimeKind.Local).AddTicks(9722), new DateTime(2021, 5, 3, 16, 40, 26, 186, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(71), new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(89), new DateTime(2021, 5, 3, 16, 40, 26, 187, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(2213), new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(7167), new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(7257), new DateTime(2021, 5, 3, 16, 40, 26, 192, DateTimeKind.Local).AddTicks(7252) });
        }
    }
}

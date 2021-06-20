using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Players_PlayerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PlayerId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Players",
                nullable: true);

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
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 708, DateTimeKind.Local).AddTicks(1247), new DateTime(2021, 5, 14, 16, 49, 0, 708, DateTimeKind.Local).AddTicks(1232), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2376), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2365), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2578), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2575), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2603), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2601), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2619), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2617), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2643), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2641), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2658), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2656), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2674), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2672), null });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2689), new DateTime(2021, 5, 14, 16, 49, 0, 709, DateTimeKind.Local).AddTicks(2687), null });

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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6356), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6404), new DateTime(2021, 5, 14, 16, 49, 0, 707, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_UserId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Players");

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
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(8974), new DateTime(2021, 5, 5, 11, 13, 56, 378, DateTimeKind.Local).AddTicks(8960), "fotomaykon.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9604), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9581), "fotosamuel.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9813), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9809), "fotocelio.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9835), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9832), "fotojose.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9849), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9847), "fotomauricio.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9873), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9870), "fotofernando.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9887), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9884), "fotoadam.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9900), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9898), "fotoemerson.png" });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro", "FotoURL" },
                values: new object[] { new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9913), new DateTime(2021, 5, 5, 11, 13, 56, 379, DateTimeKind.Local).AddTicks(9911), "fotojullius.png" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlayerId",
                table: "Users",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Players_PlayerId",
                table: "Users",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

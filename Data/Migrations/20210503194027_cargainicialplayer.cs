using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class cargainicialplayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 190, DateTimeKind.Local).AddTicks(5003), new DateTime(2021, 5, 3, 16, 40, 26, 190, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5715), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5959), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5994), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6025), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6075), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6108), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6138), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "dataAtualizacao", "dataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6169), new DateTime(2021, 5, 3, 16, 40, 26, 191, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Celular", "DataAtualizacao", "DataCadastro", "DataNascimento", "FotoURL", "Nome", "Numero", "PerfilPlayer", "PlayerAtivo", "PosicaoA", "PosicaoP", "Psn", "TeamId" },
                values: new object[,]
                {
                    { 1, "31993712719", new DateTime(2021, 5, 3, 16, 40, 26, 193, DateTimeKind.Local).AddTicks(3624), new DateTime(2021, 5, 3, 16, 40, 26, 193, DateTimeKind.Local).AddTicks(3608), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotomaykon.png", "Maykon", 13, "Jogador", true, "Volante", "Meia Atacante", "Maykon1993", 1 },
                    { 9, "44961242145", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(621), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(619), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotojullius.png", "Jullius", 7, "Jogador", true, "agueiro", "Atacante", "cachaca", 3 },
                    { 8, "11978113211", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(608), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(606), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotoemerson.png", "Emerson", 7, "Jogador", true, "Atacante", "Volante", "emer", 3 },
                    { 7, "31993154719", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(595), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(593), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotoadam.png", "Adam", 7, "Jogador", true, "Lateral", "Zagueiro", "adao", 3 },
                    { 6, "44967542145", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(582), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(580), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotofernando.png", "Fernando", 7, "Jogador", true, "Lateral", "Meia Atacante", "fernando123", 2 },
                    { 5, "11978653211", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(558), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(556), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotomauricio.png", "Mauricio", 7, "Jogador", true, "Volante", "Goleiro", "maumau", 2 },
                    { 4, "31993122719", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(544), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(542), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotojose.png", "Jose", 7, "Jogador", true, "Volante", "Atacante", "joselito1970", 2 },
                    { 3, "44967543245", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(523), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(520), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotocelio.png", "Celio", 7, "Jogador", true, "Volante", "Atacante", "Celio_Shadow_14", 1 },
                    { 2, "11978653211", new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(302), new DateTime(2021, 5, 3, 16, 40, 26, 195, DateTimeKind.Local).AddTicks(276), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fotosamuel.png", "Samuel", 7, "Jogador", true, "Volante", "Meia Atacante", "santacruzpe", 1 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3445), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3679) });

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
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3811), new DateTime(2021, 5, 3, 15, 48, 11, 265, DateTimeKind.Local).AddTicks(3825) });

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
    }
}

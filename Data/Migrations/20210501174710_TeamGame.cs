using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TeamGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "TeamId", "adversario", "data", "dataAtualizacao", "dataCadastro", "dtAdversario", "dtCadastro", "horario", "psnAdversario", "telefoneAdversario", "tipoJogo" },
                values: new object[,]
                {
                    { 1, 1, "Tombense", new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(5210), new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(9761), new DateTime(2021, 5, 1, 14, 47, 8, 112, DateTimeKind.Local).AddTicks(9779), "Zezinho", "Maykon", "16:30", "tomtom", "31956785421", "Camp. Mineiro" },
                    { 2, 1, "America", new DateTime(2021, 5, 2, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4193), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4631), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(4648), "Lisca", "Isabela", "22:00", "liscadoid", "31956784321", "Camp. Mineiro" },
                    { 3, 1, "Cruzeiro", new DateTime(2021, 5, 3, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5028), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5047), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5052), "Felipe", "Ramiro", "16:00", "conception", "38991081254", "Camp. Mineiro" },
                    { 4, 2, "Tombense", new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5063), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5072), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5079), "Zezinho", "Maykon", "16:30", "tomtom", "31956785421", "Camp. Mineiro" },
                    { 5, 2, "America", new DateTime(2021, 5, 5, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5084), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5093), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5096), "Lisca", "Isabela", "22:00", "liscadoid", "31956784321", "Camp. Mineiro" },
                    { 6, 2, "Cruzeiro", new DateTime(2021, 5, 5, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5123), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5135), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5143), "Felipe", "Ramiro", "16:00", "conception", "38991081254", "Camp. Mineiro" },
                    { 7, 3, "Tombense", new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5157), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5167), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5175), "Zezinho", "Maykon", "16:30", "tomtom", "31956785421", "Camp. Mineiro" },
                    { 8, 3, "America", new DateTime(2021, 5, 2, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5189), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5200), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5208), "Lisca", "Isabela", "22:00", "liscadoid", "31956784321", "Camp. Mineiro" },
                    { 9, 3, "Cruzeiro", new DateTime(2021, 5, 3, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5222), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5233), new DateTime(2021, 5, 1, 14, 47, 8, 114, DateTimeKind.Local).AddTicks(5241), "Felipe", "Ramiro", "16:00", "conception", "38991081254", "Camp. Mineiro" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 14, 52, 341, DateTimeKind.Local).AddTicks(1853), new DateTime(2021, 5, 1, 13, 14, 52, 349, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 14, 52, 350, DateTimeKind.Local).AddTicks(4097), new DateTime(2021, 5, 1, 13, 14, 52, 350, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 14, 52, 350, DateTimeKind.Local).AddTicks(4722), new DateTime(2021, 5, 1, 13, 14, 52, 350, DateTimeKind.Local).AddTicks(4805) });
        }
    }
}

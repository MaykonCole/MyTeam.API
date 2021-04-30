using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersApp_Times_TimeId",
                table: "PlayersApp");

            migrationBuilder.DropIndex(
                name: "IX_PlayersApp_TimeId",
                table: "PlayersApp");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "PlayersApp");

            migrationBuilder.AlterColumn<bool>(
                name: "PlayerAtivo",
                table: "Players",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 660, DateTimeKind.Local).AddTicks(5930), new DateTime(2021, 4, 30, 8, 52, 29, 660, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9571), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9860), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9893), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9909), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9931), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9947), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9959), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9971), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 652, DateTimeKind.Local).AddTicks(4354), new DateTime(2021, 4, 30, 8, 52, 29, 656, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 657, DateTimeKind.Local).AddTicks(6157), new DateTime(2021, 4, 30, 8, 52, 29, 657, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 8, 52, 29, 657, DateTimeKind.Local).AddTicks(6386), new DateTime(2021, 4, 30, 8, 52, 29, 657, DateTimeKind.Local).AddTicks(6414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "PlayersApp",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PlayerAtivo",
                table: "Players",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 318, DateTimeKind.Local).AddTicks(94), new DateTime(2021, 4, 26, 7, 56, 2, 318, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(3556), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4029), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4088), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4122), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4169), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4197), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4225), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4253), new DateTime(2021, 4, 26, 7, 56, 2, 320, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 306, DateTimeKind.Local).AddTicks(6836), new DateTime(2021, 4, 26, 7, 56, 2, 314, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4156), new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4395), new DateTime(2021, 4, 26, 7, 56, 2, 315, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.CreateIndex(
                name: "IX_PlayersApp_TimeId",
                table: "PlayersApp",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersApp_Times_TimeId",
                table: "PlayersApp",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

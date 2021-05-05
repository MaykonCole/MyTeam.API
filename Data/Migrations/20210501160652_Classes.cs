using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Times_TeamId",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameIndex(
                name: "IX_Game_TeamId",
                table: "Games",
                newName: "IX_Games_TeamId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Times",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "PlayersApp",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Psn",
                table: "PlayersApp",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProcuraTime",
                table: "PlayersApp",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "PlayersApp",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PlayersApp",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 6, 51, 824, DateTimeKind.Local).AddTicks(689), new DateTime(2021, 5, 1, 13, 6, 51, 829, DateTimeKind.Local).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 6, 51, 829, DateTimeKind.Local).AddTicks(7448), new DateTime(2021, 5, 1, 13, 6, 51, 829, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 1, 13, 6, 51, 829, DateTimeKind.Local).AddTicks(7683), new DateTime(2021, 5, 1, 13, 6, 51, 829, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Times_TeamId",
                table: "Games",
                column: "TeamId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Times_TeamId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameIndex(
                name: "IX_Games_TeamId",
                table: "Game",
                newName: "IX_Game_TeamId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Times",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "PlayersApp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Psn",
                table: "PlayersApp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ProcuraTime",
                table: "PlayersApp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "PlayersApp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "PlayersApp",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 17, 48, 25, 94, DateTimeKind.Local).AddTicks(6647), new DateTime(2021, 4, 30, 17, 48, 25, 99, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 17, 48, 25, 100, DateTimeKind.Local).AddTicks(8033), new DateTime(2021, 4, 30, 17, 48, 25, 100, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 4, 30, 17, 48, 25, 100, DateTimeKind.Local).AddTicks(8539), new DateTime(2021, 4, 30, 17, 48, 25, 100, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Times_TeamId",
                table: "Game",
                column: "TeamId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

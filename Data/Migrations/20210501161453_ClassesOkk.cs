using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassesOkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Times_TeamId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Times_TimeId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TimeId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "IdTeam",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Games",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Times_TeamId",
                table: "Games",
                column: "TeamId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Times_TeamId",
                table: "Players",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Times_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdTeam",
                table: "Games",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Players_TimeId",
                table: "Players",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Times_TeamId",
                table: "Games",
                column: "TeamId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Times_TimeId",
                table: "Players",
                column: "TimeId",
                principalTable: "Times",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

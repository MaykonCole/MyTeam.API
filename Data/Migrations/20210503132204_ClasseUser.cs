using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClasseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerfilUsuario",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 608, DateTimeKind.Local).AddTicks(2339), new DateTime(2021, 5, 3, 10, 22, 3, 608, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 609, DateTimeKind.Local).AddTicks(9669), new DateTime(2021, 5, 3, 10, 22, 3, 609, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(246), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "07-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(342), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(433), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(544), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(633), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(726), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 593, DateTimeKind.Local).AddTicks(5524), new DateTime(2021, 5, 3, 10, 22, 3, 602, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3525), new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(3978), new DateTime(2021, 5, 3, 10, 22, 3, 603, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DataAtualizacao", "DataCadastro", "Email", "Login", "PlayerId", "Senha" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(7528), new DateTime(2021, 5, 3, 10, 22, 3, 610, DateTimeKind.Local).AddTicks(7506), "maykontaiorpm@gmail.com", "Maykon1993", null, "teste@123" },
                    { 2, new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4116), "belbelm@gmail.com", "belcastroic", null, "teste@123" },
                    { 3, new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4201), new DateTime(2021, 5, 3, 10, 22, 3, 611, DateTimeKind.Local).AddTicks(4198), "santacruz@gmail.com", "santacruzpe451", null, "teste@123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "PerfilUsuario",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5729), new DateTime(2021, 5, 2, 12, 8, 17, 74, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6129), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "02-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6368), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "06-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6395), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6419), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "04-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6456), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "03-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6480), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6505), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "data", "dataAtualizacao", "dataCadastro" },
                values: new object[] { "05-05-2021", new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6530), new DateTime(2021, 5, 2, 12, 8, 17, 75, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 64, DateTimeKind.Local).AddTicks(8587), new DateTime(2021, 5, 2, 12, 8, 17, 70, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(718), new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Times",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCadastro" },
                values: new object[] { new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1021), new DateTime(2021, 5, 2, 12, 8, 17, 71, DateTimeKind.Local).AddTicks(1045) });
        }
    }
}

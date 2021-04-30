using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ClassesOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "NomeTime",
                table: "Times",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Psn",
                table: "Players",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PerfilPlayer",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Players",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Players",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Players",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoURL",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosicaoA",
                table: "Players",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosicaoP",
                table: "Players",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtCadastro = table.Column<string>(nullable: true),
                    adversario = table.Column<string>(maxLength: 20, nullable: false),
                    telefoneAdversario = table.Column<string>(nullable: true),
                    dtAdversario = table.Column<string>(nullable: true),
                    psnAdversario = table.Column<string>(maxLength: 20, nullable: false),
                    horario = table.Column<string>(maxLength: 5, nullable: false),
                    data = table.Column<DateTime>(nullable: false),
                    dataAtualizacao = table.Column<DateTime>(nullable: false),
                    dataCadastro = table.Column<DateTime>(nullable: false),
                    tipoJogo = table.Column<string>(nullable: true),
                    IdTeam = table.Column<int>(nullable: true),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Times_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Times",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 20, nullable: false),
                    Senha = table.Column<string>(maxLength: 20, nullable: false),
                    PerfilUsuario = table.Column<string>(maxLength: 20, nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    DataAtualizacao = table.Column<DateTime>(nullable: false),
                    PlayerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Game_TeamId",
                table: "Game",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PlayerId",
                table: "Users",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "FotoURL",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PosicaoA",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PosicaoP",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "NomeTime",
                table: "Times",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Psn",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "PerfilPlayer",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Numero",
                table: "Players",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Celular", "DataAtualizacao", "DataCadastro", "DataNascimento", "Nome", "Numero", "PerfilPlayer", "PlayerAtivo", "Psn", "TimeId" },
                values: new object[,]
                {
                    { 1, "31993712719", new DateTime(2021, 4, 30, 8, 52, 29, 660, DateTimeKind.Local).AddTicks(5930), new DateTime(2021, 4, 30, 8, 52, 29, 660, DateTimeKind.Local).AddTicks(9324), new DateTime(1993, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maykon", 13, "Jogador", false, "Maykon1993", 1 },
                    { 2, "11978653211", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9571), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9675), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel", 7, "Jogador", true, "santacruzpe", 1 },
                    { 3, "44967543245", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9860), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9887), new DateTime(1989, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celio", 9, "DT", true, "Celio_Shadow_14", 1 },
                    { 4, "31993122719", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9893), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9905), new DateTime(1978, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jose", 5, "Jogador", true, "joselito1970", 2 },
                    { 5, "11978653211", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9909), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9918), new DateTime(1990, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mauricio", 6, "DT", true, "maumau", 2 },
                    { 6, "44967542145", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9931), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9943), new DateTime(1980, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernando", 10, "Jogador", false, "fernando123", 2 },
                    { 7, "31993154719", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9947), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9956), new DateTime(1994, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", 2, "DT", true, "adao", 3 },
                    { 8, "11978113211", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9959), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9968), new DateTime(1998, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emerson", 8, "Jogador", false, "emer", 3 },
                    { 9, "44961242145", new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9971), new DateTime(2021, 4, 30, 8, 52, 29, 661, DateTimeKind.Local).AddTicks(9979), new DateTime(1988, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jullius", 3, "Jogador", true, "cachaca", 3 }
                });

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
    }
}

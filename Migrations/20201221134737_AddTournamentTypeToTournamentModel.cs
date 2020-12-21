using Microsoft.EntityFrameworkCore.Migrations;

namespace TournamentApplication.Migrations
{
    public partial class AddTournamentTypeToTournamentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TournamentInfo",
                table: "Tournament",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerAmount",
                table: "Tournament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TournamentType",
                table: "Tournament",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerAmount",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "TournamentType",
                table: "Tournament");

            migrationBuilder.AlterColumn<string>(
                name: "TournamentInfo",
                table: "Tournament",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

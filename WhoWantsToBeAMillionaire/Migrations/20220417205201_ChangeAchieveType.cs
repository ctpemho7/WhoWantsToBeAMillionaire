using Microsoft.EntityFrameworkCore.Migrations;

namespace WhoWantsToBeAMillionaire.Migrations
{
    public partial class ChangeAchieveType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Achieve",
                table: "Achievements",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Achieve",
                table: "Achievements",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}

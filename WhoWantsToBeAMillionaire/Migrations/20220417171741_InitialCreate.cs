using Microsoft.EntityFrameworkCore.Migrations;

namespace WhoWantsToBeAMillionaire.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Achieve = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QText = table.Column<string>(nullable: true),
                    QAnswerA = table.Column<string>(nullable: true),
                    QAnswerB = table.Column<string>(nullable: true),
                    QAnswerC = table.Column<string>(nullable: true),
                    QAnswerD = table.Column<string>(nullable: true),
                    QRightAnswer = table.Column<int>(nullable: false),
                    QLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}

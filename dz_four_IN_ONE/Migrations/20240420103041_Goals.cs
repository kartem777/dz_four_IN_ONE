using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dz_four_IN_ONE.Migrations
{
    /// <inheritdoc />
    public partial class Goals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Sity = table.Column<string>(type: "TEXT", nullable: false),
                    LoseCount = table.Column<int>(type: "INTEGER", nullable: false),
                    WinCount = table.Column<int>(type: "INTEGER", nullable: false),
                    DrawCount = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalsWin = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalsLose = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tournament");
        }
    }
}

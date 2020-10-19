using Microsoft.EntityFrameworkCore.Migrations;

namespace BookFinder.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    isbn = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    author = table.Column<string>(nullable: true),
                    publisher = table.Column<string>(nullable: true),
                    cost = table.Column<float>(nullable: false),
                    descriptuon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.isbn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

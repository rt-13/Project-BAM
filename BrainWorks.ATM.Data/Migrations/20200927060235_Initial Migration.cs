using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainWorks.ATM.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(200)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(200)", nullable: false),
                    Address1 = table.Column<string>(type: "varchar(500)", nullable: false),
                    Address2 = table.Column<string>(type: "varchar(500)", nullable: true),
                    Landmark = table.Column<string>(type: "varchar(100)", nullable: true),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    State = table.Column<string>(type: "varchar(50)", nullable: false),
                    Pin = table.Column<string>(type: "varchar(6)", nullable: false),
                    Mobile = table.Column<string>(type: "varchar(20)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

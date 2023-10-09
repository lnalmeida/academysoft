using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademySoft.Infra.Data.Migrations
{
    public partial class CreateDbUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(80)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");
        }
    }
}

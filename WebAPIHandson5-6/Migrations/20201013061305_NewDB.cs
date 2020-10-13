using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIHandson5_6.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "varchar(30)", nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    IsPermanent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emp");
        }
    }
}

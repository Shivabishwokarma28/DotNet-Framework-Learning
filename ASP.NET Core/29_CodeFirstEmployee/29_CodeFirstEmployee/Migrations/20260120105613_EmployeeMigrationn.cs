using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _29_CodeFirstEmployee.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeMigrationn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Emp_Address = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Emp_Designation = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

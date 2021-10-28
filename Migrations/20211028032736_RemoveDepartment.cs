using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeCRUD_MVC.Migrations
{
    public partial class RemoveDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentsDepartmentName",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentsDepartmentName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentsDepartmentName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentsDepartmentName",
                table: "Employees",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentsDepartmentName",
                table: "Employees",
                column: "DepartmentsDepartmentName");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentsDepartmentName",
                table: "Employees",
                column: "DepartmentsDepartmentName",
                principalTable: "Departments",
                principalColumn: "DepartmentName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

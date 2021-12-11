using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamProject.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "department_id",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_department_id",
                table: "Employees",
                column: "department_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_department_id",
                table: "Employees",
                column: "department_id",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_department_id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_department_id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "Employees");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EmploymentSystemMvc.Migrations
{
    public partial class RemoveConcernForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concern_Employee_EmployeeId",
                table: "Concern");

            migrationBuilder.DropIndex(
                name: "IX_Concern_EmployeeId",
                table: "Concern");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Concern_EmployeeId",
                table: "Concern",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concern_Employee_EmployeeId",
                table: "Concern",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

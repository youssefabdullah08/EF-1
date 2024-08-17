using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_1.Migrations
{
    /// <inheritdoc />
    public partial class relDeptIns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructors",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_depts_DeptId",
                table: "Instructors",
                column: "DeptId",
                principalTable: "depts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_depts_DeptId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DeptId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Instructors");
        }
    }
}

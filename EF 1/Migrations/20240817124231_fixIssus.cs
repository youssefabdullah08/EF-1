using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_1.Migrations
{
    /// <inheritdoc />
    public partial class fixIssus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stdcrs",
                table: "stdcrs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crsins",
                table: "Crsins");

            migrationBuilder.RenameColumn(
                name: "Crsid",
                table: "stdcrs",
                newName: "Coreseid");

            migrationBuilder.RenameColumn(
                name: "Stdid",
                table: "stdcrs",
                newName: "Studentid");

            migrationBuilder.RenameColumn(
                name: "Crsid",
                table: "Crsins",
                newName: "CoresesId");

            migrationBuilder.RenameColumn(
                name: "insid",
                table: "Crsins",
                newName: "InstructorId");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Studentid",
                table: "stdcrs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "stdcrs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "depts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "Crsins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CoresesId1",
                table: "Crsins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_stdcrs",
                table: "stdcrs",
                columns: new[] { "Studentid", "Coreseid" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crsins",
                table: "Crsins",
                columns: new[] { "InstructorId", "CoresesId" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_stdcrs_Coreseid",
                table: "stdcrs",
                column: "Coreseid");

            migrationBuilder.CreateIndex(
                name: "IX_stdcrs_StudentId",
                table: "stdcrs",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Crsins_CoresesId",
                table: "Crsins",
                column: "CoresesId");

            migrationBuilder.CreateIndex(
                name: "IX_Crsins_CoresesId1",
                table: "Crsins",
                column: "CoresesId1");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crsins_Courses_CoresesId",
                table: "Crsins",
                column: "CoresesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crsins_Courses_CoresesId1",
                table: "Crsins",
                column: "CoresesId1",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Crsins_Instructors_InstructorId",
                table: "Crsins",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_depts_Instructors_Id",
                table: "depts",
                column: "Id",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stdcrs_Courses_Coreseid",
                table: "stdcrs",
                column: "Coreseid",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stdcrs_Students_StudentId",
                table: "stdcrs",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stdcrs_Students_Studentid",
                table: "stdcrs",
                column: "Studentid",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_depts_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "depts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Crsins_Courses_CoresesId",
                table: "Crsins");

            migrationBuilder.DropForeignKey(
                name: "FK_Crsins_Courses_CoresesId1",
                table: "Crsins");

            migrationBuilder.DropForeignKey(
                name: "FK_Crsins_Instructors_InstructorId",
                table: "Crsins");

            migrationBuilder.DropForeignKey(
                name: "FK_depts_Instructors_Id",
                table: "depts");

            migrationBuilder.DropForeignKey(
                name: "FK_stdcrs_Courses_Coreseid",
                table: "stdcrs");

            migrationBuilder.DropForeignKey(
                name: "FK_stdcrs_Students_StudentId",
                table: "stdcrs");

            migrationBuilder.DropForeignKey(
                name: "FK_stdcrs_Students_Studentid",
                table: "stdcrs");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_depts_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stdcrs",
                table: "stdcrs");

            migrationBuilder.DropIndex(
                name: "IX_stdcrs_Coreseid",
                table: "stdcrs");

            migrationBuilder.DropIndex(
                name: "IX_stdcrs_StudentId",
                table: "stdcrs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crsins",
                table: "Crsins");

            migrationBuilder.DropIndex(
                name: "IX_Crsins_CoresesId",
                table: "Crsins");

            migrationBuilder.DropIndex(
                name: "IX_Crsins_CoresesId1",
                table: "Crsins");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "stdcrs");

            migrationBuilder.DropColumn(
                name: "CoresesId1",
                table: "Crsins");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Coreseid",
                table: "stdcrs",
                newName: "Crsid");

            migrationBuilder.RenameColumn(
                name: "Studentid",
                table: "stdcrs",
                newName: "Stdid");

            migrationBuilder.RenameColumn(
                name: "CoresesId",
                table: "Crsins",
                newName: "Crsid");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Crsins",
                newName: "insid");

            migrationBuilder.AlterColumn<int>(
                name: "Stdid",
                table: "stdcrs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "depts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "insid",
                table: "Crsins",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stdcrs",
                table: "stdcrs",
                column: "Stdid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crsins",
                table: "Crsins",
                column: "insid");
        }
    }
}

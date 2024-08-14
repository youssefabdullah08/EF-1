using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_1.Migrations
{
    /// <inheritdoc />
    public partial class createRestOfDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crsins",
                columns: table => new
                {
                    insid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crsid = table.Column<int>(type: "int", nullable: false),
                    evaluate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crsins", x => x.insid);
                });

            migrationBuilder.CreateTable(
                name: "depts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Insid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hiredate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stdcrs",
                columns: table => new
                {
                    Stdid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crsid = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stdcrs", x => x.Stdid);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crsins");

            migrationBuilder.DropTable(
                name: "depts");

            migrationBuilder.DropTable(
                name: "stdcrs");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}

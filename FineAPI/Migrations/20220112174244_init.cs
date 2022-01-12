using Microsoft.EntityFrameworkCore.Migrations;

namespace FineAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "type_fine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_fine", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_id = table.Column<int>(type: "int", nullable: false),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    avto_id = table.Column<int>(type: "int", nullable: false),
                    sumary_fine = table.Column<int>(type: "int", nullable: false),
                    status_fine = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fine", x => x.id);
                    table.ForeignKey(
                        name: "FK_fine_type_fine_type_id",
                        column: x => x.type_id,
                        principalTable: "type_fine",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_fine_type_id",
                table: "fine",
                column: "type_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fine");

            migrationBuilder.DropTable(
                name: "type_fine");
        }
    }
}

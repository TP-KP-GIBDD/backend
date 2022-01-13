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
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    article = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "type_fine",
                columns: new[] { "id", "article", "name" },
                values: new object[] { 1, "264.1", "Вождение в нетрезвом виде" });

            migrationBuilder.InsertData(
                table: "type_fine",
                columns: new[] { "id", "article", "name" },
                values: new object[] { 2, "12.9", "Превышение скорости" });

            migrationBuilder.InsertData(
                table: "type_fine",
                columns: new[] { "id", "article", "name" },
                values: new object[] { 3, "124.2", "Парковка в неположеном месте" });

            migrationBuilder.InsertData(
                table: "fine",
                columns: new[] { "id", "avto_id", "person_id", "status_fine", "sumary_fine", "type_id" },
                values: new object[] { 1, 1, 6, "Не оплачен", 30000, 1 });

            migrationBuilder.InsertData(
                table: "fine",
                columns: new[] { "id", "avto_id", "person_id", "status_fine", "sumary_fine", "type_id" },
                values: new object[] { 2, 2, 7, "Не оплачен", 500, 2 });

            migrationBuilder.InsertData(
                table: "fine",
                columns: new[] { "id", "avto_id", "person_id", "status_fine", "sumary_fine", "type_id" },
                values: new object[] { 3, 1, 7, "Не оплачен", 1500, 3 });

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

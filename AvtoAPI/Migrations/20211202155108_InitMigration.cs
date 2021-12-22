using Microsoft.EntityFrameworkCore.Migrations;

namespace AvtoAPI.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "body_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_body_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rudder",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rudder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "avto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    body_type_id = table.Column<int>(type: "int", nullable: false),
                    rudder_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avto", x => x.id);
                    table.ForeignKey(
                        name: "FK_avto_body_type_body_type_id",
                        column: x => x.body_type_id,
                        principalTable: "body_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avto_rudder_rudder_id",
                        column: x => x.rudder_id,
                        principalTable: "rudder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "car_owner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    person_id = table.Column<int>(type: "int", nullable: false),
                    avto_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car_owner", x => x.id);
                    table.ForeignKey(
                        name: "FK_car_owner_avto_avto_id",
                        column: x => x.avto_id,
                        principalTable: "avto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberlicense = table.Column<int>(type: "int", nullable: false),
                    numberpasport = table.Column<int>(type: "int", nullable: false),
                    AvtoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.id);
                    table.ForeignKey(
                        name: "FK_person_avto_AvtoId",
                        column: x => x.AvtoId,
                        principalTable: "avto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_avto_body_type_id",
                table: "avto",
                column: "body_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_rudder_id",
                table: "avto",
                column: "rudder_id");

            migrationBuilder.CreateIndex(
                name: "IX_car_owner_avto_id",
                table: "car_owner",
                column: "avto_id");

            migrationBuilder.CreateIndex(
                name: "IX_person_AvtoId",
                table: "person",
                column: "AvtoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "car_owner");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "avto");

            migrationBuilder.DropTable(
                name: "body_type");

            migrationBuilder.DropTable(
                name: "rudder");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AvtoAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_owner_avto_avto_id",
                table: "car_owner");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropIndex(
                name: "IX_car_owner_avto_id",
                table: "car_owner");

            migrationBuilder.AddColumn<int>(
                name: "number_avto",
                table: "avto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "vin",
                table: "avto",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "number_avto",
                table: "avto");

            migrationBuilder.DropColumn(
                name: "vin",
                table: "avto");

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvtoId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberlicense = table.Column<int>(type: "int", nullable: false),
                    numberpasport = table.Column<int>(type: "int", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "IX_car_owner_avto_id",
                table: "car_owner",
                column: "avto_id");

            migrationBuilder.CreateIndex(
                name: "IX_person_AvtoId",
                table: "person",
                column: "AvtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_car_owner_avto_avto_id",
                table: "car_owner",
                column: "avto_id",
                principalTable: "avto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

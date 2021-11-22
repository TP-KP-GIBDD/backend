using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionId",
                table: "GibddOffices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GibddOffices_RegionId",
                table: "GibddOffices",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_GibddOffices_Regions_RegionId",
                table: "GibddOffices",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GibddOffices_Regions_RegionId",
                table: "GibddOffices");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_GibddOffices_RegionId",
                table: "GibddOffices");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "GibddOffices");
        }
    }
}

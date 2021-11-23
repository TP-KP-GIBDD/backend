using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GibddOffices",
                columns: new[] { "Id", "Lat", "Lon", "Name", "RegionId" },
                values: new object[] { 1, 56.433999999999997, 54.432000000000002, "Управление ГИБДД УМВД России по Владимирской обл.", 1 });

            migrationBuilder.InsertData(
                table: "GibddOffices",
                columns: new[] { "Id", "Lat", "Lon", "Name", "RegionId" },
                values: new object[] { 2, 57.433999999999997, 55.432000000000002, "Отдел ГИБДД по Суздальскому району", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GibddOffices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GibddOffices",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

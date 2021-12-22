using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GibddOffices",
                columns: new[] { "Id", "Lat", "Lon", "Name", "RegionId" },
                values: new object[] { 6, 57.000352999999997, 40.973930000000003, "Управление ГИБДД по г. Иваново", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GibddOffices",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RegistrationServices_ServiceDateTimeId",
                table: "RegistrationServices");

            migrationBuilder.AddColumn<double>(
                name: "lat",
                table: "Regions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "lon",
                table: "Regions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "lat", "lon" },
                values: new object[] { 56.129057000000003, 40.406635000000001 });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "lat", "lon" },
                values: new object[] { 55.753219999999999, 37.622512999999998 });

            migrationBuilder.UpdateData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "lat", "lon" },
                values: new object[] { 57.000352999999997, 40.973930000000003 });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationServices_ServiceDateTimeId",
                table: "RegistrationServices",
                column: "ServiceDateTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RegistrationServices_ServiceDateTimeId",
                table: "RegistrationServices");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "Regions");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationServices_ServiceDateTimeId",
                table: "RegistrationServices",
                column: "ServiceDateTimeId",
                unique: true);
        }
    }
}

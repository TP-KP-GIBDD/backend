using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeOfService",
                table: "Services");

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Паспорт гражданина РФ");

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Водительское удостоверение" },
                    { 3, "Документ о сдаче экзамена ПДД" },
                    { 4, "Договор купли-продажи транспортного средства" },
                    { 5, "Страховой полис" },
                    { 6, "Технический паспорт транспортного средства" },
                    { 7, "Документ собственника транспортного средства" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Постановка автомобиля на учёт" },
                    { 2, "Получение водительского удостоверения" },
                    { 3, "Замена водительского удостоверения" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfService",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Documents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Test");
        }
    }
}

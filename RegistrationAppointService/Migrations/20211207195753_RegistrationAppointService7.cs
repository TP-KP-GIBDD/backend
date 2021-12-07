using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointService7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceDateTimes",
                columns: new[] { "Id", "Date", "IsFree", "Time" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "9:15" },
                    { 21, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "13:45" },
                    { 20, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "13:30" },
                    { 19, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "13:15" },
                    { 18, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "13:00" },
                    { 17, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "12:00" },
                    { 16, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "11:45" },
                    { 15, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "11:30" },
                    { 14, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "11:15" },
                    { 13, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "11:00" },
                    { 12, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "10:45" },
                    { 11, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "10:30" },
                    { 10, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "10:15" },
                    { 9, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "10:00" },
                    { 8, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "9:45" },
                    { 7, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "9:30" },
                    { 22, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "14:00" },
                    { 23, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "14:15" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ServiceDateTimes",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}

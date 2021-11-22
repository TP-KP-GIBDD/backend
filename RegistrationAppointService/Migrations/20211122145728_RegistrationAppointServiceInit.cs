using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationAppointService.Migrations
{
    public partial class RegistrationAppointServiceInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GibddOffices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<double>(type: "float", nullable: false),
                    Lon = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GibddOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDateTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDateTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfService = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentService",
                columns: table => new
                {
                    DocumentsId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentService", x => new { x.DocumentsId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_DocumentService_Documents_DocumentsId",
                        column: x => x.DocumentsId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentService_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    CarOwnerId = table.Column<int>(type: "int", nullable: false),
                    GibddOfficeId = table.Column<int>(type: "int", nullable: false),
                    ServiceDateTimeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationServices_GibddOffices_GibddOfficeId",
                        column: x => x.GibddOfficeId,
                        principalTable: "GibddOffices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationServices_ServiceDateTimes_ServiceDateTimeId",
                        column: x => x.ServiceDateTimeId,
                        principalTable: "ServiceDateTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentService_ServicesId",
                table: "DocumentService",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationServices_GibddOfficeId",
                table: "RegistrationServices",
                column: "GibddOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationServices_ServiceDateTimeId",
                table: "RegistrationServices",
                column: "ServiceDateTimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationServices_ServiceId",
                table: "RegistrationServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentService");

            migrationBuilder.DropTable(
                name: "RegistrationServices");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "GibddOffices");

            migrationBuilder.DropTable(
                name: "ServiceDateTimes");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}

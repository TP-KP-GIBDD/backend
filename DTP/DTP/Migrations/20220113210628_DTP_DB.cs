using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTP.Migrations
{
    public partial class DTP_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitube = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeViolations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeViolations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceViolation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoordinatesId = table.Column<int>(type: "int", nullable: false),
                    TypeLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadSigns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MethodTrafficRegulation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadMarkup = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceViolation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceViolation_Coordinates_CoordinatesId",
                        column: x => x.CoordinatesId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identifier = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InspectorId = table.Column<int>(type: "int", nullable: false),
                    placeViolationId = table.Column<int>(type: "int", nullable: false),
                    typeViolationId = table.Column<int>(type: "int", nullable: false),
                    participantsId = table.Column<int>(type: "int", nullable: false),
                    avtoId = table.Column<int>(type: "int", nullable: false),
                    damage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    violation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protocols_Participants_participantsId",
                        column: x => x.participantsId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protocols_PlaceViolation_placeViolationId",
                        column: x => x.placeViolationId,
                        principalTable: "PlaceViolation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Protocols_TypeViolations_typeViolationId",
                        column: x => x.typeViolationId,
                        principalTable: "TypeViolations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TypeViolations",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { 1, "столкновение транспортных средств" },
                    { 2, "наезд на припятствие" },
                    { 3, "опрокидывание/съезд в кювет" },
                    { 4, "наезд на пешехода" },
                    { 5, "наезд на животное" },
                    { 6, "другое" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaceViolation_CoordinatesId",
                table: "PlaceViolation",
                column: "CoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_participantsId",
                table: "Protocols",
                column: "participantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_placeViolationId",
                table: "Protocols",
                column: "placeViolationId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_typeViolationId",
                table: "Protocols",
                column: "typeViolationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "PlaceViolation");

            migrationBuilder.DropTable(
                name: "TypeViolations");

            migrationBuilder.DropTable(
                name: "Coordinates");
        }
    }
}

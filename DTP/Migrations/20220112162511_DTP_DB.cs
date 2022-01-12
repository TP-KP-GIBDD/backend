using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DTP.Migrations
{
    public partial class DTP_DB : Migration
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
                name: "brand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Longitube = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
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
                name: "brand_model",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brand_model", x => x.id);
                    table.ForeignKey(
                        name: "FK_brand_model_brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "avto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number_avto = table.Column<int>(type: "int", nullable: false),
                    vin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    brand_model_id = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    color_id = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_avto_brand_model_brand_model_id",
                        column: x => x.brand_model_id,
                        principalTable: "brand_model",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_avto_color_color_id",
                        column: x => x.color_id,
                        principalTable: "color",
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
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avtoId = table.Column<int>(type: "int", nullable: false),
                    damage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_avto_avtoId",
                        column: x => x.avtoId,
                        principalTable: "avto",
                        principalColumn: "id",
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
                    inspector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loginInspector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placeViolationId = table.Column<int>(type: "int", nullable: false),
                    typeViolationId = table.Column<int>(type: "int", nullable: false),
                    participantsId = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_avto_body_type_id",
                table: "avto",
                column: "body_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_brand_model_id",
                table: "avto",
                column: "brand_model_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_color_id",
                table: "avto",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "IX_avto_rudder_id",
                table: "avto",
                column: "rudder_id");

            migrationBuilder.CreateIndex(
                name: "IX_brand_model_BrandId",
                table: "brand_model",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_avtoId",
                table: "Participants",
                column: "avtoId");

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
                name: "avto");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "body_type");

            migrationBuilder.DropTable(
                name: "brand_model");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "rudder");

            migrationBuilder.DropTable(
                name: "brand");
        }
    }
}

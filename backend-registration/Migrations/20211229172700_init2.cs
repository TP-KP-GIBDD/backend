using Microsoft.EntityFrameworkCore.Migrations;

namespace Registration.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Data_AccountId",
                table: "Data");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Accounts",
                newName: "MiddleName");

            migrationBuilder.AddColumn<string>(
                name: "Birthday",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataId",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Data_AccountId",
                table: "Data",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Data_AccountId",
                table: "Data");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "DataId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Accounts",
                newName: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Data_AccountId",
                table: "Data",
                column: "AccountId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DEA_Program.Data.Migrations
{
    public partial class RemoveTheRequiredForPersonAndVehicleIdFromCustomControlTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbCustomControls_DbPersons_PersonId",
                table: "DbCustomControls");

            migrationBuilder.DropForeignKey(
                name: "FK_DbCustomControls_DbVehicles_VehicleId",
                table: "DbCustomControls");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "DbCustomControls",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "DbCustomControls",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_DbCustomControls_DbPersons_PersonId",
                table: "DbCustomControls",
                column: "PersonId",
                principalTable: "DbPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DbCustomControls_DbVehicles_VehicleId",
                table: "DbCustomControls",
                column: "VehicleId",
                principalTable: "DbVehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbCustomControls_DbPersons_PersonId",
                table: "DbCustomControls");

            migrationBuilder.DropForeignKey(
                name: "FK_DbCustomControls_DbVehicles_VehicleId",
                table: "DbCustomControls");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "DbCustomControls",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "DbCustomControls",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DbCustomControls_DbPersons_PersonId",
                table: "DbCustomControls",
                column: "PersonId",
                principalTable: "DbPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbCustomControls_DbVehicles_VehicleId",
                table: "DbCustomControls",
                column: "VehicleId",
                principalTable: "DbVehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

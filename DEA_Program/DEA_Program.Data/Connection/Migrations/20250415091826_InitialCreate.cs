using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DEA_Program.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(maxLength: 120, nullable: false),
                    LastName = table.Column<string>(maxLength: 120, nullable: false),
                    PersonalId = table.Column<string>(maxLength: 10, nullable: false),
                    DayofBirth = table.Column<DateTime>(nullable: false),
                    CountryCode = table.Column<int>(nullable: false),
                    AdditionInformation = table.Column<string>(maxLength: 1200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbPersons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(maxLength: 120, nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    RegistrationNumber = table.Column<string>(maxLength: 10, nullable: false),
                    CountryCode = table.Column<int>(maxLength: 5, nullable: false),
                    AdditionalInformationAboutTheVehicle = table.Column<string>(maxLength: 1200, nullable: true),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbVehicles_DbPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "DbPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DbCustomControls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayOfVerification = table.Column<DateTime>(nullable: false),
                    AdditionalInformationAboutTheControl = table.Column<string>(maxLength: 1200, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCustomControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbCustomControls_DbPersons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "DbPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DbCustomControls_DbVehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "DbVehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbCustomControls_PersonId",
                table: "DbCustomControls",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DbCustomControls_VehicleId",
                table: "DbCustomControls",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_DbVehicles_PersonId",
                table: "DbVehicles",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbCustomControls");

            migrationBuilder.DropTable(
                name: "DbUsers");

            migrationBuilder.DropTable(
                name: "DbVehicles");

            migrationBuilder.DropTable(
                name: "DbPersons");
        }
    }
}

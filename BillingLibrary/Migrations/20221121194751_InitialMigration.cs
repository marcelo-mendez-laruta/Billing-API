using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BillingLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Period = table.Column<int>(type: "INTEGER", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    state = table.Column<string>(type: "TEXT", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ClientModelId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Clients_ClientModelId",
                        column: x => x.ClientModelId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Id", "Amount", "Category", "ClientId", "ClientModelId", "CreatedOn", "Period", "UpdatedOn", "state" },
                values: new object[,]
                {
                    { 1, 0.99189049940981m, "SEWER", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8484), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8484), "Pending" },
                    { 2, 0.55169781052477m, "SEWER", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8535), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8535), "Pending" },
                    { 3, 0.446380794059207m, "ELECTRICITY", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8537), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8538), "Pending" },
                    { 4, 0.333095093639911m, "ELECTRICITY", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8540), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8540), "Pending" },
                    { 5, 0.25697477362134m, "WATER", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8542), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8543), "Pending" },
                    { 6, 0.92189068694969m, "WATER", 1, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8547), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8548), "Pending" },
                    { 7, 0.12353522778867m, "SEWER", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8550), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8550), "Pending" },
                    { 8, 0.385353059924271m, "SEWER", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8553), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8553), "Pending" },
                    { 9, 0.341528808053661m, "ELECTRICITY", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8555), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8556), "Pending" },
                    { 10, 0.433490466808958m, "ELECTRICITY", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8559), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8560), "Pending" },
                    { 11, 0.125487542634803m, "WATER", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8562), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8562), "Pending" },
                    { 12, 0.238826462657073m, "WATER", 2, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8565), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8565), "Pending" },
                    { 13, 0.959969244256725m, "SEWER", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8567), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8567), "Pending" },
                    { 14, 0.912970758181196m, "SEWER", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8571), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8572), "Pending" },
                    { 15, 0.474639056016261m, "ELECTRICITY", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8574), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8575), "Pending" },
                    { 16, 0.668130261668923m, "ELECTRICITY", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8577), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8577), "Pending" },
                    { 17, 0.966838782572578m, "WATER", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8579), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8580), "Pending" },
                    { 18, 0.712906273014131m, "WATER", 3, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8583), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8584), "Pending" },
                    { 19, 0.487092710911679m, "SEWER", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8586), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8586), "Pending" },
                    { 20, 0.515092176613846m, "SEWER", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8588), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8589), "Pending" },
                    { 21, 0.473430586815036m, "ELECTRICITY", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8591), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8591), "Pending" },
                    { 22, 0.068158217428612m, "ELECTRICITY", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8632), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8633), "Pending" },
                    { 23, 0.340807169970969m, "WATER", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8635), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8636), "Pending" },
                    { 24, 0.316480027058623m, "WATER", 4, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8637), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8638), "Pending" },
                    { 25, 0.0536241983024341m, "SEWER", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8640), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8640), "Pending" },
                    { 26, 0.940668601854327m, "SEWER", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8645), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8645), "Pending" },
                    { 27, 0.340016102806142m, "ELECTRICITY", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8647), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8648), "Pending" },
                    { 28, 0.544094823654411m, "ELECTRICITY", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8650), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8650), "Pending" },
                    { 29, 0.770515330231688m, "WATER", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8652), 202001, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8653), "Pending" },
                    { 30, 0.141469505692545m, "WATER", 5, null, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8657), 202002, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8657), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8423), "Joseph Carlton", new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8427) },
                    { 2, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8432), "Maria Juarez", new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8433) },
                    { 3, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8434), "Albert Kenny", new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8434) },
                    { 4, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8435), "Jessica Phillips", new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8435) },
                    { 5, new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8436), "Charles Johnson", new DateTime(2022, 11, 21, 15, 47, 51, 629, DateTimeKind.Local).AddTicks(8437) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ClientModelId",
                table: "Bills",
                column: "ClientModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}

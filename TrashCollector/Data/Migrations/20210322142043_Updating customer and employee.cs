using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Updatingcustomerandemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "444aa5be-79c7-4913-a95a-90042be22343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6ee5c4-bbe5-443a-a9ab-d7a6d2bde2a3");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PickUpMonth = table.Column<string>(nullable: true),
                    PickUpDay = table.Column<string>(nullable: true),
                    PickUpYear = table.Column<string>(nullable: true),
                    ExtraPickUpMonth = table.Column<string>(nullable: true),
                    ExtraPickUpDay = table.Column<string>(nullable: true),
                    ExtraPickUpYear = table.Column<string>(nullable: true),
                    StartOfSuspensionMonth = table.Column<string>(nullable: true),
                    StartOfSuspensionDay = table.Column<string>(nullable: true),
                    StartOfSuspensionYear = table.Column<string>(nullable: true),
                    EndOfSuspensionMonth = table.Column<string>(nullable: true),
                    EndOfSuspensionDay = table.Column<string>(nullable: true),
                    EndOfSuspensionYear = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62389713-1e2a-409f-9e08-3d8682b92579", "27741131-829c-4e7b-97fa-9b00940093da", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7df5f03d-905a-4b9a-9d68-c9ac0e46cc88", "0079ddea-d59f-4d3b-b1f2-821081af0494", "Customer", "CUSTOMER" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62389713-1e2a-409f-9e08-3d8682b92579");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7df5f03d-905a-4b9a-9d68-c9ac0e46cc88");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b6ee5c4-bbe5-443a-a9ab-d7a6d2bde2a3", "c0c922ee-c79e-47b7-896c-dabf667af1df", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "444aa5be-79c7-4913-a95a-90042be22343", "68492d8e-2d2f-4adb-8757-72ac77f5cb1c", "Customer", "Customer" });
        }
    }
}

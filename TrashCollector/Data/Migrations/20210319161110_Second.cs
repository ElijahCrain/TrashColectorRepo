using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "905ee5a2-f594-43a0-9450-4dfc3fa8fcb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab320aa-5880-4c9b-b0c0-c757b60ef917");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b6ee5c4-bbe5-443a-a9ab-d7a6d2bde2a3", "c0c922ee-c79e-47b7-896c-dabf667af1df", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "444aa5be-79c7-4913-a95a-90042be22343", "68492d8e-2d2f-4adb-8757-72ac77f5cb1c", "Customer", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "444aa5be-79c7-4913-a95a-90042be22343");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b6ee5c4-bbe5-443a-a9ab-d7a6d2bde2a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cab320aa-5880-4c9b-b0c0-c757b60ef917", "43978138-a91f-4324-a9eb-ae2cb55c971e", "Employee", "Employee" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "905ee5a2-f594-43a0-9450-4dfc3fa8fcb6", "70ba0309-3f67-4128-86eb-acb09133cd46", "Customer", "Customer" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class MigrationfortheEmployeeVeiws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d28b6c0-a800-48a5-ada6-d5de9f50bfba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e329f466-5f87-4b1c-b8b5-ed1e42981415");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef976f64-3038-4d51-bd5a-bcca6875c0f6", "f87f05cf-3cef-4bc6-8907-0330d1507927", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf96acd0-592a-454e-ac30-5f2a18b3ba0c", "45a1096d-7f68-4719-a08f-dc30e7498607", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf96acd0-592a-454e-ac30-5f2a18b3ba0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef976f64-3038-4d51-bd5a-bcca6875c0f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d28b6c0-a800-48a5-ada6-d5de9f50bfba", "5d5a1dc0-54b6-4937-bcb2-59409fbcf032", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e329f466-5f87-4b1c-b8b5-ed1e42981415", "bb55f6ff-9014-434f-98b6-178dfe499ed2", "Customer", "CUSTOMER" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Steepsales.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "orderFirm",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "orderName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9dba6860-1ed7-4568-8c1b-94f4031e7de4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfa9a233-3726-429e-ab30-8064dda1d6dd", "AQAAAAEAACcQAAAAEDTSQwlU8Ci5+llYCjd36nAcw08Ql8dto6gT+VIhR07s3ABw8Pgf0bP1xLRWXDQNVw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderFirm",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "orderName",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "470d6edb-0123-4733-a2d5-d2177aadf07f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47f0f645-53a7-460d-8377-028e45b29fd7", "AQAAAAEAACcQAAAAEKlZGD3odqZ3bzmnREH6w1kLgQZeFV182by9mO2wM3ie3v/L9y4dSr5acfw2c03w3g==" });
        }
    }
}

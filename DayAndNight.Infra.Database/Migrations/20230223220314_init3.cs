using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayAndNightCoffee.Infra.Database.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryProduct_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct");

            migrationBuilder.RenameTable(
                name: "CategoryProduct",
                newName: "CategoryProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryProducts",
                table: "CategoryProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryProducts_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CategoryProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryProducts_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryProducts",
                table: "CategoryProducts");

            migrationBuilder.RenameTable(
                name: "CategoryProducts",
                newName: "CategoryProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryProduct_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CategoryProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

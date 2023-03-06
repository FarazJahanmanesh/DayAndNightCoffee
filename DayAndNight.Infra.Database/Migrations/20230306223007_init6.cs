using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DayAndNightCoffee.Infra.Database.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cartId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cart_cartId",
                        column: x => x.cartId,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartId",
                table: "Products",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_cartId",
                table: "Users",
                column: "cartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cart_CartId",
                table: "Products",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoryProduct_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "CategoryProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cart_CartId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoryProduct_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryProduct",
                table: "CategoryProduct");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

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
    }
}

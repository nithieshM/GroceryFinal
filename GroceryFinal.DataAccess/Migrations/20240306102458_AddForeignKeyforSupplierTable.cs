using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryFinal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyforSupplierTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "ProductTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTable_SupplierId",
                table: "ProductTable",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTable_SupplierTable_SupplierId",
                table: "ProductTable",
                column: "SupplierId",
                principalTable: "SupplierTable",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTable_SupplierTable_SupplierId",
                table: "ProductTable");

            migrationBuilder.DropIndex(
                name: "IX_ProductTable_SupplierId",
                table: "ProductTable");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "ProductTable");
        }
    }
}

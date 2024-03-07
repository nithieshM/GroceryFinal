using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryFinal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDetailsTable",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerZipCode = table.Column<int>(type: "int", nullable: false),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetailsTable", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTable",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierZipCode = table.Column<int>(type: "int", nullable: false),
                    SupplierPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTable", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "UOMTable",
                columns: table => new
                {
                    UOMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UOMName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOMTable", x => x.UOMId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTable",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseRate = table.Column<double>(type: "float", nullable: false),
                    SellingRate = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<double>(type: "float", nullable: false),
                    PurchaseStock = table.Column<double>(type: "float", nullable: false),
                    SellingStock = table.Column<double>(type: "float", nullable: false),
                    ReorderLevel = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    UOMId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTable", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductTable_SupplierTable_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "SupplierTable",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTable_UOMTable_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOMTable",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTable_SupplierId",
                table: "ProductTable",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTable_UOMId",
                table: "ProductTable",
                column: "UOMId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDetailsTable");

            migrationBuilder.DropTable(
                name: "ProductTable");

            migrationBuilder.DropTable(
                name: "SupplierTable");

            migrationBuilder.DropTable(
                name: "UOMTable");
        }
    }
}

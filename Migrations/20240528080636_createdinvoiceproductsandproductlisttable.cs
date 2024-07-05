using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class createdinvoiceproductsandproductlisttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranspotationDetails_BillsList_InvoiceId",
                table: "TranspotationDetails");

            migrationBuilder.DropIndex(
                name: "IX_TranspotationDetails_InvoiceId",
                table: "TranspotationDetails");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "TranspotationDetails");

            migrationBuilder.RenameColumn(
                name: "TextileName",
                table: "UsersList",
                newName: "UserTextileName");

            migrationBuilder.RenameColumn(
                name: "VehicleNo",
                table: "TranspotationDetails",
                newName: "TranspotationVehicleNo");

            migrationBuilder.RenameColumn(
                name: "ClientGST",
                table: "ClientsList",
                newName: "ClientGSTNo");

            migrationBuilder.AddColumn<decimal>(
                name: "CGSTAmount",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CGSTPercentage",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FinalTotalAmount",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RoundOff",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SGSTAmount",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SGSTPercentage",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "BillsList",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "ProductsList",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsList", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceProductDetails",
                columns: table => new
                {
                    ProductDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ClientHSNCode = table.Column<int>(type: "int", nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    ProductRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductTotalAmount = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceProductDetails", x => x.ProductDetailsId);
                    table.ForeignKey(
                        name: "FK_InvoiceProductDetails_BillsList_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "BillsList",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceProductDetails_ProductsList_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ProductsList",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceProductDetails_InvoiceId",
                table: "InvoiceProductDetails",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceProductDetails_ProductId",
                table: "InvoiceProductDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceProductDetails");

            migrationBuilder.DropTable(
                name: "ProductsList");

            migrationBuilder.DropColumn(
                name: "CGSTAmount",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "CGSTPercentage",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "FinalTotalAmount",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "RoundOff",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "SGSTAmount",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "SGSTPercentage",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "BillsList");

            migrationBuilder.RenameColumn(
                name: "UserTextileName",
                table: "UsersList",
                newName: "TextileName");

            migrationBuilder.RenameColumn(
                name: "TranspotationVehicleNo",
                table: "TranspotationDetails",
                newName: "VehicleNo");

            migrationBuilder.RenameColumn(
                name: "ClientGSTNo",
                table: "ClientsList",
                newName: "ClientGST");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "TranspotationDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TranspotationDetails_InvoiceId",
                table: "TranspotationDetails",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranspotationDetails_BillsList_InvoiceId",
                table: "TranspotationDetails",
                column: "InvoiceId",
                principalTable: "BillsList",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

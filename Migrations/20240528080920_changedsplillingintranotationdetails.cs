using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class changedsplillingintranotationdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransPotationTime",
                table: "TranspotationDetails",
                newName: "TranspotationTime");

            migrationBuilder.RenameColumn(
                name: "TransPotationDate",
                table: "TranspotationDetails",
                newName: "TranspotationDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TranspotationTime",
                table: "TranspotationDetails",
                newName: "TransPotationTime");

            migrationBuilder.RenameColumn(
                name: "TranspotationDate",
                table: "TranspotationDetails",
                newName: "TransPotationDate");
        }
    }
}

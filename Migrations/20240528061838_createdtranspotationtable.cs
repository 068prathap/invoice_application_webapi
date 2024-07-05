using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class createdtranspotationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TranspotationId",
                table: "BillsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TranspotationDetails",
                columns: table => new
                {
                    TranspotationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranspotationMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransPotationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TransPotationTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranspotationDetails", x => x.TranspotationId);
                    table.ForeignKey(
                        name: "FK_TranspotationDetails_BillsList_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "BillsList",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillsList_TranspotationId",
                table: "BillsList",
                column: "TranspotationId");

            migrationBuilder.CreateIndex(
                name: "IX_TranspotationDetails_InvoiceId",
                table: "TranspotationDetails",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillsList_TranspotationDetails_TranspotationId",
                table: "BillsList",
                column: "TranspotationId",
                principalTable: "TranspotationDetails",
                principalColumn: "TranspotationId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillsList_TranspotationDetails_TranspotationId",
                table: "BillsList");

            migrationBuilder.DropTable(
                name: "TranspotationDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillsList_TranspotationId",
                table: "BillsList");

            migrationBuilder.DropColumn(
                name: "TranspotationId",
                table: "BillsList");
        }
    }
}

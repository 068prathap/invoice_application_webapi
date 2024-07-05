using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class addedforeginkeyinbillslist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BillsList_ClientId",
                table: "BillsList",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillsList_ClientsList_ClientId",
                table: "BillsList",
                column: "ClientId",
                principalTable: "ClientsList",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillsList_ClientsList_ClientId",
                table: "BillsList");

            migrationBuilder.DropIndex(
                name: "IX_BillsList_ClientId",
                table: "BillsList");
        }
    }
}

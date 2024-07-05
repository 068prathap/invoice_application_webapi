using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceApplication.Migrations
{
    /// <inheritdoc />
    public partial class Createduserprofileandbankdetailstable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBankDetails",
                columns: table => new
                {
                    BankDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFSCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBankDetails", x => x.BankDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "UsersProfile",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankDetailsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProfile", x => x.ProfileId);
                    table.ForeignKey(
                        name: "FK_UsersProfile_UserBankDetails_BankDetailsId",
                        column: x => x.BankDetailsId,
                        principalTable: "UserBankDetails",
                        principalColumn: "BankDetailsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersProfile_UsersList_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersList",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersProfile_BankDetailsId",
                table: "UsersProfile",
                column: "BankDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProfile_UserId",
                table: "UsersProfile",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersProfile");

            migrationBuilder.DropTable(
                name: "UserBankDetails");
        }
    }
}

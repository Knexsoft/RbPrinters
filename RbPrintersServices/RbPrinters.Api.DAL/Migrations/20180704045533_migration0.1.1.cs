using Microsoft.EntityFrameworkCore.Migrations;

namespace RbPrinters.Api.DAL.Migrations
{
    public partial class migration011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MoblieNumber_Alt",
                table: "Users",
                newName: "MoblieAlt");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "Users",
                newName: "Mobile");

            migrationBuilder.RenameIndex(
                name: "IX_Users_MobileNumber",
                table: "Users",
                newName: "IX_Users_Mobile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MoblieAlt",
                table: "Users",
                newName: "MoblieNumber_Alt");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Users",
                newName: "MobileNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Mobile",
                table: "Users",
                newName: "IX_Users_MobileNumber");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountAPI.Infrastructures.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.EnsureSchema(
                name: "Recurly");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account",
                newSchema: "Recurly");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                schema: "Recurly",
                table: "Account",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                schema: "Recurly",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "Account",
                schema: "Recurly",
                newName: "Accounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Migrations
{
    public partial class alter_field_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomId",
                schema: "dbo",
                table: "Transactions",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomId",
                schema: "dbo",
                table: "Transactions",
                newName: "IX_Transactions_CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerId",
                schema: "dbo",
                table: "Transactions",
                newName: "CustomId");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CustomerId",
                schema: "dbo",
                table: "Transactions",
                newName: "IX_Transactions_CustomId");
        }
    }
}

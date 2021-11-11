using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingApp.Migrations
{
    public partial class alter_field_numberCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberCard",
                schema: "dbo",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberCard",
                schema: "dbo",
                table: "Cards");
        }
    }
}

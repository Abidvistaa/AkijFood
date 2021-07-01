using Microsoft.EntityFrameworkCore.Migrations;

namespace AkijFood.Migrations
{
    public partial class AddChangesToQuantityAndUnitPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumUnitPrice",
                table: "tblColdDrinks",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "NumQuantity",
                table: "tblColdDrinks",
                newName: "Quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "tblColdDrinks",
                newName: "NumUnitPrice");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "tblColdDrinks",
                newName: "NumQuantity");
        }
    }
}

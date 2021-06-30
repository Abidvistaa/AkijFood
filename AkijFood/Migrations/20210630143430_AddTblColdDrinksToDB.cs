using Microsoft.EntityFrameworkCore.Migrations;

namespace AkijFood.Migrations
{
    public partial class AddTblColdDrinksToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblColdDrinks",
                columns: table => new
                {
                    ColdDrinksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColdDrinksName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    NumQuantity = table.Column<decimal>(type: "decimal(4)", nullable: false),
                    NumUnitPrice = table.Column<decimal>(type: "decimal(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblColdDrinks", x => x.ColdDrinksId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblColdDrinks");
        }
    }
}

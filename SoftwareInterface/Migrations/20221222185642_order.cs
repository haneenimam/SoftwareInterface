using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftwareInterface.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.CreateTable(
                name: "Orrders",
                columns: table => new
                {
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    Area = table.Column<string>(type: "TEXT", nullable: false),
                    Paymentmethod = table.Column<string>(type: "TEXT", nullable: false),
                    Cardnumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Totalamount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orrders", x => x.city);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orrders");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    Area = table.Column<string>(type: "TEXT", nullable: false),
                    Cardnumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Paymentmethod = table.Column<string>(type: "TEXT", nullable: false),
                    Totalamount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.city);
                });
        }
    }
}

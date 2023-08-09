using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encoca.DataAccessLayer.Migrations
{
    public partial class initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarrierConfigurationId",
                table: "Carriers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarrierConfigurationId",
                table: "Carriers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

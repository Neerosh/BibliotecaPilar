using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BibliotecaPilar.Migrations
{
    /// <inheritdoc />
    public partial class AddedReserveTotal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ReserveTotal",
                table: "Reserves",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReserveTotal",
                table: "Reserves");
        }
    }
}

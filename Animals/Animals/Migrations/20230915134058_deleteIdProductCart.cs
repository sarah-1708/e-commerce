using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animals.Migrations
{
    /// <inheritdoc />
    public partial class deleteIdProductCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductCarts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductCarts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

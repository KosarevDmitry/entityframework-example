using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efapi.Migrations
{
    /// <inheritdoc />
    public partial class BlogUodate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StreetId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TownId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "StreetId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "Blogs");
        }
    }
}

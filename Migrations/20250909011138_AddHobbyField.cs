using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddHobbyField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hobby",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobby",
                table: "People");
        }
    }
}

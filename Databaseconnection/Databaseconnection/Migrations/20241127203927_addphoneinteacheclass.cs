using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Databaseconnection.Migrations
{
    /// <inheritdoc />
    public partial class addphoneinteacheclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "tbl_teacher",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "tbl_teacher");
        }
    }
}

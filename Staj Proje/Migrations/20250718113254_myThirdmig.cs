using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Proje.Migrations
{
    /// <inheritdoc />
    public partial class myThirdmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mayDeleTed",
                table: "myprojecTs");

            migrationBuilder.DropColumn(
                name: "TopprojecT",
                table: "homes");

            migrationBuilder.DropColumn(
                name: "mypicTureURL",
                table: "homes");

            migrationBuilder.DropColumn(
                name: "mayDeleTed",
                table: "caTegories");

            migrationBuilder.DropColumn(
                name: "mybiographyURL",
                table: "abouTMes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "mayDeleTed",
                table: "myprojecTs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TopprojecT",
                table: "homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mypicTureURL",
                table: "homes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "mayDeleTed",
                table: "caTegories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "mybiographyURL",
                table: "abouTMes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

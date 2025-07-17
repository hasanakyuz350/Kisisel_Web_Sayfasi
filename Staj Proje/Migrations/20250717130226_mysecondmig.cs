﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Proje.Migrations
{
    /// <inheritdoc />
    public partial class mysecondmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "auThormail",
                table: "commenTs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "auThormail",
                table: "commenTs");
        }
    }
}

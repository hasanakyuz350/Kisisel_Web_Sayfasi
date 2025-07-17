using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Proje.Migrations
{
    /// <inheritdoc />
    public partial class myfirsTmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouTMes",
                columns: table => new
                {
                    abouTmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    abouTme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    myBiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mypicTureURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdaTeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    mybiographyURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouTMes", x => x.abouTmeID);
                });

            migrationBuilder.CreateTable(
                name: "conTacTss",
                columns: table => new
                {
                    conTacTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firsTname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lasTname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subjecT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senTTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    auThorIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    answercommenTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conTacTss", x => x.conTacTID);
                });

            migrationBuilder.CreateTable(
                name: "homes",
                columns: table => new
                {
                    homeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiTle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subTiTle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortabouTme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopprojecT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mypicTureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updaTeTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homes", x => x.homeID);
                });

            migrationBuilder.CreateTable(
                name: "caTegories",
                columns: table => new
                {
                    caTegoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    caTegoryname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    abouTmeID = table.Column<int>(type: "int", nullable: false),
                    UpdaTeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    mayDeleTed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caTegories", x => x.caTegoryID);
                    table.ForeignKey(
                        name: "FK_caTegories_abouTMes_abouTmeID",
                        column: x => x.abouTmeID,
                        principalTable: "abouTMes",
                        principalColumn: "abouTmeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "myprojecTs",
                columns: table => new
                {
                    projecTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiTle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shorTdecripTion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripTion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projecTImageURl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeID = table.Column<int>(type: "int", nullable: false),
                    giThublink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    demolink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caTegory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updaTeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    mayDeleTed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myprojecTs", x => x.projecTID);
                    table.ForeignKey(
                        name: "FK_myprojecTs_homes_homeID",
                        column: x => x.homeID,
                        principalTable: "homes",
                        principalColumn: "homeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "commenTs",
                columns: table => new
                {
                    commeTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    auThorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    auThorsurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    auThormessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wriTeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projecTID = table.Column<int>(type: "int", nullable: false),
                    adminbackcommenT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mayDeleTed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commenTs", x => x.commeTID);
                    table.ForeignKey(
                        name: "FK_commenTs_myprojecTs_projecTID",
                        column: x => x.projecTID,
                        principalTable: "myprojecTs",
                        principalColumn: "projecTID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_caTegories_abouTmeID",
                table: "caTegories",
                column: "abouTmeID");

            migrationBuilder.CreateIndex(
                name: "IX_commenTs_projecTID",
                table: "commenTs",
                column: "projecTID");

            migrationBuilder.CreateIndex(
                name: "IX_myprojecTs_homeID",
                table: "myprojecTs",
                column: "homeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caTegories");

            migrationBuilder.DropTable(
                name: "commenTs");

            migrationBuilder.DropTable(
                name: "conTacTss");

            migrationBuilder.DropTable(
                name: "abouTMes");

            migrationBuilder.DropTable(
                name: "myprojecTs");

            migrationBuilder.DropTable(
                name: "homes");
        }
    }
}

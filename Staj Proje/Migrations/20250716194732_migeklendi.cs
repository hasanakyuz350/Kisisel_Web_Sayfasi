using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Staj_Proje.Migrations
{
    /// <inheritdoc />
    public partial class migeklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conTacT",
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
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    AnswercommenT = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conTacT", x => x.conTacTID);
                });

            migrationBuilder.CreateTable(
                name: "mainpage_abouTme",
                columns: table => new
                {
                    mainpage_abouTmeID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_mainpage_abouTme", x => x.mainpage_abouTmeID);
                });

            migrationBuilder.CreateTable(
                name: "myprojecT",
                columns: table => new
                {
                    projecTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiTle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shorTdecripTion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripTion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    projecTImageURl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    giThublink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    demolink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    caTegory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updaTeTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleTed = table.Column<bool>(type: "bit", nullable: false),
                    Homemainpage_abouTmeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myprojecT", x => x.projecTID);
                    table.ForeignKey(
                        name: "FK_myprojecT_mainpage_abouTme_Homemainpage_abouTmeID",
                        column: x => x.Homemainpage_abouTmeID,
                        principalTable: "mainpage_abouTme",
                        principalColumn: "mainpage_abouTmeID");
                });

            migrationBuilder.CreateTable(
                name: "commenT",
                columns: table => new
                {
                    commeTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    auThorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    auThorsurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    wriTeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projecTID1 = table.Column<int>(type: "int", nullable: false),
                    admnbackcommenT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleTed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commenT", x => x.commeTID);
                    table.ForeignKey(
                        name: "FK_commenT_myprojecT_projecTID1",
                        column: x => x.projecTID1,
                        principalTable: "myprojecT",
                        principalColumn: "projecTID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_commenT_projecTID1",
                table: "commenT",
                column: "projecTID1");

            migrationBuilder.CreateIndex(
                name: "IX_myprojecT_Homemainpage_abouTmeID",
                table: "myprojecT",
                column: "Homemainpage_abouTmeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "commenT");

            migrationBuilder.DropTable(
                name: "conTacT");

            migrationBuilder.DropTable(
                name: "myprojecT");

            migrationBuilder.DropTable(
                name: "mainpage_abouTme");
        }
    }
}

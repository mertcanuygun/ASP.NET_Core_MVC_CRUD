using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CountryDB_MVC.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContinentID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentID",
                        column: x => x.ContinentID,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country_Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_Languages_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Country_Languages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false),
                    GDP = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedMachineName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountryDetail_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "ContinentName", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeleteDate", "DeletedIpAddress", "DeletedMachineName", "UpdateDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, "Europe", null, null, null, null, null, null, null, null, null },
                    { 2, "Asia", null, null, null, null, null, null, null, null, null },
                    { 3, "Africa", null, null, null, null, null, null, null, null, null },
                    { 4, "America", null, null, null, null, null, null, null, null, null },
                    { 5, "Oceania", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeleteDate", "DeletedIpAddress", "DeletedMachineName", "LanguageName", "UpdateDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "English", null, null, null },
                    { 2, null, null, null, null, null, null, "Chinese", null, null, null },
                    { 3, null, null, null, null, null, null, "Turkish", null, null, null },
                    { 4, null, null, null, null, null, null, "Spanish", null, null, null },
                    { 5, null, null, null, null, null, null, "Afrikaans", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentID", "CountryName", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeleteDate", "DeletedIpAddress", "DeletedMachineName", "UpdateDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, 4, "Argentina", null, null, null, null, null, null, null, null, null },
                    { 2, 2, "China", null, null, null, null, null, null, null, null, null },
                    { 3, 3, "South Africa", null, null, null, null, null, null, null, null, null },
                    { 4, 5, "New Zealand", null, null, null, null, null, null, null, null, null },
                    { 5, 1, "Spain", null, null, null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "CountryDetail",
                columns: new[] { "Id", "CountryID", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeleteDate", "DeletedIpAddress", "DeletedMachineName", "GDP", "Population", "UpdateDate", "UpdatedIpAddress", "UpdatedMachineName", "Year" },
                values: new object[,]
                {
                    { 1, 5, null, null, null, null, null, null, 0m, 46580000, null, null, null, 2010 },
                    { 2, 5, null, null, null, null, null, null, 0m, 40570000, null, null, null, 2000 },
                    { 3, 4, null, null, null, null, null, null, 0m, 4350000, null, null, null, 2010 },
                    { 4, 4, null, null, null, null, null, null, 0m, 3858000, null, null, null, 2000 },
                    { 5, 4, null, null, null, null, null, null, 0m, 3330000, null, null, null, 1990 },
                    { 6, 1, null, null, null, null, null, null, 0m, 40790000, null, null, null, 2010 }
                });

            migrationBuilder.InsertData(
                table: "Country_Languages",
                columns: new[] { "Id", "CountryID", "CreateDate", "CreatedIpAddress", "CreatedMachineName", "DeleteDate", "DeletedIpAddress", "DeletedMachineName", "LanguageID", "UpdateDate", "UpdatedIpAddress", "UpdatedMachineName" },
                values: new object[,]
                {
                    { 1, 5, null, null, null, null, null, null, 4, null, null, null },
                    { 2, 2, null, null, null, null, null, null, 2, null, null, null },
                    { 3, 4, null, null, null, null, null, null, 1, null, null, null },
                    { 4, 3, null, null, null, null, null, null, 5, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentID",
                table: "Countries",
                column: "ContinentID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Languages_CountryID",
                table: "Country_Languages",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Languages_LanguageID",
                table: "Country_Languages",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_CountryDetail_CountryID",
                table: "CountryDetail",
                column: "CountryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country_Languages");

            migrationBuilder.DropTable(
                name: "CountryDetail");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Continents");
        }
    }
}

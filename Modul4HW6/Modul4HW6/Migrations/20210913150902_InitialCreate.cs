using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW6.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleasedData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenresId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtistsSongs",
                columns: table => new
                {
                    ArtistsSongsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongsId = table.Column<int>(type: "int", nullable: false),
                    ArtistsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistsSongs", x => x.ArtistsSongsId);
                    table.ForeignKey(
                        name: "FK_ArtistsSongs_Artists_ArtistsId",
                        column: x => x.ArtistsId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistsSongs_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramUrl", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2007, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "OlegPisnyar228@mail.ru", "https://www.instagram.com/OlegPisnyar", "Oleg", "+380993255632" },
                    { 2, new DateTime(1961, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "BoriaNagibator@mail.ru", "https://www.instagram.com/BoriaNagibator1961", "Boria", "+380999865002" },
                    { 3, new DateTime(1999, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "OlexandraLampovna1991@mail.ru", "https://www.instagram.com/Lampovna11", "Olexa", "+380667899945" },
                    { 4, new DateTime(1988, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Din_Don@mail.ru", "https://www.instagram.com/DonDon1988ProMaxMegaUltra", "Den", "+380665593712" },
                    { 5, new DateTime(1998, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "MaryMore@mail.ru", "https://www.instagram.com/InstaProKa4kaMary", "Mary", "+380986347196" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rok" },
                    { 2, "Rap" },
                    { 3, "Pop" },
                    { 4, "Classic" },
                    { 5, "jas" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenresId", "ReleasedData", "Title" },
                values: new object[,]
                {
                    { 1, 5.1m, 1, new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oduvan4ik" },
                    { 2, 4.055m, 2, new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mu-mu-mu" },
                    { 3, 2.17m, 3, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "NigaGan" },
                    { 4, 5.02m, 4, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "PoleRodimoeMoe" },
                    { 5, 2.16m, 5, new DateTime(2001, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GusiaUbabusi" }
                });

            migrationBuilder.InsertData(
                table: "ArtistsSongs",
                columns: new[] { "ArtistsSongsId", "ArtistsId", "SongsId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 5, 3, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 6, 4, 4 },
                    { 7, 5, 4 },
                    { 8, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistsSongs_ArtistsId",
                table: "ArtistsSongs",
                column: "ArtistsId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistsSongs_SongsId",
                table: "ArtistsSongs",
                column: "SongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenresId",
                table: "Songs",
                column: "GenresId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistsSongs");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}

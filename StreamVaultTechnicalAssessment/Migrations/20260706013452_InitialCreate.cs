using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StreamVaultTechnicalAssessment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AgeRating = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    ContentType = table.Column<int>(type: "INTEGER", nullable: false),
                    Narrator = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Duration_mins = table.Column<int>(type: "INTEGER", nullable: true),
                    Director = table.Column<string>(type: "TEXT", nullable: true),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    TrackCount = table.Column<int>(type: "INTEGER", nullable: true),
                    RecordLabel = table.Column<string>(type: "TEXT", nullable: true),
                    TotalEpisodes = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalSeasons = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Artist", "ContentType", "Description", "Genre", "RecordLabel", "ReleaseDate", "Title", "TrackCount" },
                values: new object[] { "03f06ba5-f69d-4d5c-b920-28f7e1d5345a", "G", "Marlon Cade", 3, "An acoustic folk album recorded live across small towns in the American Midwest.", "Folk", "Independent", new DateTime(2017, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roads Less Traveled", 9 });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Director", "Duration_mins", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "0e243aa2-532a-4cfc-b650-bfe6379fae0d", "R", 0, "A jazz musician uncovers a family secret during one unforgettable night in Havana.", "Carlos Ibanez", 104, "Drama", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midnight in Havana" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Author", "ContentType", "Description", "Duration_mins", "Genre", "Narrator", "ReleaseDate", "Title" },
                values: new object[] { "3f86827a-0b05-4bfb-850f-5a4ef96475d6", "PG-13", "Kate Morton", 2, "A gripping mystery spanning three generations and one haunted house.", 764, "Mystery", "Fiona Shaw", new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Clockmaker's Daughter" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Genre", "ReleaseDate", "Title", "TotalEpisodes", "TotalSeasons" },
                values: new object[,]
                {
                    { "594710ad-0b27-43fe-bcbd-75409e070014", "TV-MA", 1, "A crew of thieves exploits parallel timelines to pull off the ultimate heist.", "Sci-Fi", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quantum Heist", 8, 1 },
                    { "72683d93-31b5-44b1-8ed8-77e4d1fe92fd", "TV-14", 1, "Three generations of a family navigate secrets buried in a small coastal town.", "Drama", new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beneath the Willow", 24, 3 }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Author", "ContentType", "Description", "Duration_mins", "Genre", "Narrator", "ReleaseDate", "Title" },
                values: new object[] { "8435f185-895d-4028-b9a5-fc8ad8fde801", "PG", "Dr. Susan Cole", 2, "A marine biologist's memoir of survival and discovery in the world's deepest trenches.", 512, "Memoir", "James Holloway", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whispers of the Deep" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Director", "Duration_mins", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { "8a7f86df-9029-4ebd-903a-74e5e4579032", "PG-13", 0, "An elite squad races against time to stop a rogue AI from seizing control of a military satellite.", "Priya Nair", 132, "Action", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Horizon" },
                    { "d6c4c7bc-2049-4bc6-8b21-6fe063499c93", "PG-13", 0, "A stranded astronaut must decode a mysterious transmission before her oxygen runs out.", "Elena Marsh", 118, "Sci-Fi", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Signal" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Artist", "ContentType", "Description", "Genre", "RecordLabel", "ReleaseDate", "Title", "TrackCount" },
                values: new object[] { "ef3c9098-a1f7-490d-8a36-ec1c8c02a80c", "PG", "Vela Nightshade", 3, "A synth-driven concept album exploring isolation in a hyperconnected world.", "Electronic", "Glasswave Records", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neon Static", 11 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}

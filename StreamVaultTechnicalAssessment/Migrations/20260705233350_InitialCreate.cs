using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                values: new object[] { "0b6b67ef-8e6b-4b7d-865b-d24c535cb071", "G", "Marlon Cade", 3, "An acoustic folk album recorded live across small towns in the American Midwest.", "Folk", "Independent", new DateTime(2017, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roads Less Traveled", 9 });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Genre", "ReleaseDate", "Title", "TotalEpisodes", "TotalSeasons" },
                values: new object[] { "3f7a409e-5933-48d2-913c-10ac1051b6d7", "TV-14", 1, "Three generations of a family navigate secrets buried in a small coastal town.", "Drama", new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beneath the Willow", 24, 3 });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Director", "Duration_mins", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "4d890de3-487a-4b1f-a34e-1358a3f74233", "PG-13", 0, "An elite squad races against time to stop a rogue AI from seizing control of a military satellite.", "Priya Nair", 132, "Action", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Horizon" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Author", "ContentType", "Description", "Duration_mins", "Genre", "Narrator", "ReleaseDate", "Title" },
                values: new object[] { "5633468e-6d6a-4573-8d53-5439cbce0e88", "PG-13", "Kate Morton", 2, "A gripping mystery spanning three generations and one haunted house.", 764, "Mystery", "Fiona Shaw", new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Clockmaker's Daughter" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Director", "Duration_mins", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "671c4181-6612-44c1-9341-bb8b03916609", "R", 0, "A jazz musician uncovers a family secret during one unforgettable night in Havana.", "Carlos Ibanez", 104, "Drama", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midnight in Havana" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Artist", "ContentType", "Description", "Genre", "RecordLabel", "ReleaseDate", "Title", "TrackCount" },
                values: new object[] { "6f67ea92-e93d-43fb-bbd4-16f2e94de1b1", "PG", "Vela Nightshade", 3, "A synth-driven concept album exploring isolation in a hyperconnected world.", "Electronic", "Glasswave Records", new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neon Static", 11 });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "Author", "ContentType", "Description", "Duration_mins", "Genre", "Narrator", "ReleaseDate", "Title" },
                values: new object[] { "c4b7bdea-8d56-4aca-b757-d0c35c017b70", "PG", "Dr. Susan Cole", 2, "A marine biologist's memoir of survival and discovery in the world's deepest trenches.", 512, "Memoir", "James Holloway", new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whispers of the Deep" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Director", "Duration_mins", "Genre", "ReleaseDate", "Title" },
                values: new object[] { "d8968b1a-5dd2-425e-ab41-631925db4e51", "PG-13", 0, "A stranded astronaut must decode a mysterious transmission before her oxygen runs out.", "Elena Marsh", 118, "Sci-Fi", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Signal" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AgeRating", "ContentType", "Description", "Genre", "ReleaseDate", "Title", "TotalEpisodes", "TotalSeasons" },
                values: new object[] { "fb379c2d-7970-4f0a-ae50-b61a36cff31e", "TV-MA", 1, "A crew of thieves exploits parallel timelines to pull off the ultimate heist.", "Sci-Fi", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quantum Heist", 8, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");
        }
    }
}

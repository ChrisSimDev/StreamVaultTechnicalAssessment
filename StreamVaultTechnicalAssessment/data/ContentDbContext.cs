using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using StreamVaultTechnicalAssessment.dtos.content;
using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.data;

public class ContentDbContext(DbContextOptions<ContentDbContext> options) : DbContext(options)
{
    public DbSet<Content> Contents { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Series> Series { get; set; }
    public DbSet<Audiobook> Audiobooks { get; set; }
    public DbSet<MusicAlbum> MusicAlbums { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlite("Data Source=content.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Build db model and TPH Table
        modelBuilder.Entity<Content>()
            .HasDiscriminator<ContentType>("ContentType")
            .HasValue<Movie>(ContentType.Movie)
            .HasValue<Series>(ContentType.Series)
            .HasValue<Audiobook>(ContentType.Audiobook)
            .HasValue<MusicAlbum>(ContentType.MusicAlbum);

        // This declares the movie and audiobook duration properties to use the same column
        modelBuilder.Entity<Movie>()
            .Property(m => m.Duration_mins)
            .HasColumnName("Duration_mins");

        modelBuilder.Entity<Audiobook>()
            .Property(m => m.Duration_mins)
            .HasColumnName("Duration_mins");


        // Seed data from JSON file 
        // Note: I used LLM to write the deserialization logic as this was not critical to the assessment.
        // In a real world scenario I would not include seeding sample data in the Repo outside of testing
        var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "ContentSeedData.json"));

        var seedData = JsonDocument.Parse(json).RootElement.EnumerateArray()
            .Select(element => (Content)element.Deserialize(
                ContentTypeExtensions.GetType(
                    Enum.Parse<ContentType>(
                        element.GetProperty("contentType").GetString()!, ignoreCase: true
                        )
                    ), jsonOptions)!)
            .ToList();

        modelBuilder.Entity<Movie>().HasData(seedData.OfType<Movie>());
        modelBuilder.Entity<Series>().HasData(seedData.OfType<Series>());
        modelBuilder.Entity<Audiobook>().HasData(seedData.OfType<Audiobook>());
        modelBuilder.Entity<MusicAlbum>().HasData(seedData.OfType<MusicAlbum>());
    }
}
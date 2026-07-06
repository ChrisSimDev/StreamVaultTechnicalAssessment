using StreamVaultTechnicalAssessment.DTOs.Search;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Content;

public abstract class Content
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime ReleaseDate { get; set; } = DateTime.Now;
    public string AgeRating { get; set; } = ""; // Allows for age ratings like "PG-13", production should be an enum however this would need to consider age ratings per country
    public string Genre { get; set; } = ""; // This would be better as an enum, and should consider multiple genres in production.

    public abstract ContentType ToEnum();

    public ContentListItem ToContentListItem()
    => new(
            Id: Id,
            Title: Title,
            ContentType: ToEnum()
        );
}
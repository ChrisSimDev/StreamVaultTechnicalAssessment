using StreamVaultTechnicalAssessment.DTOs.Search;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.Models;

public class ContentIndexViewModel
{
    public List<ContentListItem> ContentList { get; init; } = [];
    public ContentType? ContentType { get; init; }
    public string? SearchTerm { get; init; }
}

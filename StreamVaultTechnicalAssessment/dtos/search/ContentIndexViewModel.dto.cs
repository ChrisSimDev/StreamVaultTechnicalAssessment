using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.dtos.search;

public class ContentIndexViewModel
{
    public List<ContentListItem> ContentList { get; init; } = [];
    public ContentType? ContentType { get; init; }
    public string? SearchTerm { get; init; }
}

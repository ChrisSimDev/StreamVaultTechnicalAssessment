using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Search;

public record ContentListItem(
    string Id, 
    string Title, 
    ContentType ContentType);

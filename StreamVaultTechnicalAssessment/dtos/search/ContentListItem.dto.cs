using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.dtos.search;

public record ContentListItem(
    string Id, 
    string Title, 
    ContentType ContentType);

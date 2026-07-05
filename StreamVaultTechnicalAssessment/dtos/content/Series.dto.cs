using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.dtos.content;

public class Series : Content
{
    public int TotalEpisodes { get; set; } = 0;
    public int TotalSeasons { get; set; } = 0;

    public override ContentType ToEnum()
    => ContentType.Series;
}

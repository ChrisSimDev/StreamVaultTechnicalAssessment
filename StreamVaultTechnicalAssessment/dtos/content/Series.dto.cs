using System.ComponentModel.DataAnnotations;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Content;

public class Series : Content
{
    [Range(1, int.MaxValue, ErrorMessage = "Total episodes must be a positive number.")]
    public int TotalEpisodes { get; set; } = 1;

    [Range(1, int.MaxValue, ErrorMessage = "Total seasons must be a positive number.")]
    public int TotalSeasons { get; set; } = 1;

    public override ContentType ToEnum()
    => ContentType.Series;
}

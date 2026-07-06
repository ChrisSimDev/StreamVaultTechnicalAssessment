using System.ComponentModel.DataAnnotations;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Content;

public class Movie : Content
{
    public string Director { get; set; } = "";

    [Range(1, int.MaxValue, ErrorMessage = "Duration must be a positive number of minutes.")]
    public int Duration_mins { get; set; } = 1;

    public override ContentType ToEnum()
    => ContentType.Movie;
}

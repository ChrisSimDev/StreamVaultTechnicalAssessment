using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.dtos.content;

public class Movie : Content
{
    public string Director { get; set; } = "";
    public int Duration_mins { get; set; } = 0;

    public override ContentType ToEnum()
    => ContentType.Movie;
}

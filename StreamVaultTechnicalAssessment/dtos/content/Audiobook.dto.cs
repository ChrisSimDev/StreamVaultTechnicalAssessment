using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.dtos.content;

public class Audiobook : Content
{
    public string Narrator { get; set; } = "";
    public string Author { get; set; } = "";
    public int Duration_mins { get; set; } = 0;

    public override ContentType ToEnum()
    => ContentType.Audiobook;
}

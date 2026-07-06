using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Content;

public class MusicAlbum : Content
{
    public string Artist { get; set; } = "";
    public int TrackCount { get; set; } = 0;
    public string RecordLabel { get; set; } = "";

    public override ContentType ToEnum()
    => ContentType.MusicAlbum;
}

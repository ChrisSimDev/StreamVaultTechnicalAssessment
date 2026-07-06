using System.ComponentModel.DataAnnotations;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.DTOs.Content;

public class MusicAlbum : Content
{
    public string Artist { get; set; } = "";

    [Range(1, int.MaxValue, ErrorMessage = "Track count must be a positive number.")]
    public int TrackCount { get; set; } = 1;

    public string RecordLabel { get; set; } = "";

    public override ContentType ToEnum()
    => ContentType.MusicAlbum;
}

using StreamVaultTechnicalAssessment.DTOs.Content;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.Models;

public class ContentItemViewModel
{
    public ContentType ContentType { get; set; } = ContentType.Movie;
    public string? Id { get; set; }
    public Movie Movie { get; set; } = new();
    public Series Series { get; set; } = new();
    public Audiobook Audiobook { get; set; } = new();
    public MusicAlbum MusicAlbum { get; set; } = new();
}

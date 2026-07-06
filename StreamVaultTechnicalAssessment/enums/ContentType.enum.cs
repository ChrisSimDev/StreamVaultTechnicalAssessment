using StreamVaultTechnicalAssessment.DTOs.Content;

namespace StreamVaultTechnicalAssessment.Enums;

public enum ContentType
{
    Movie,
    Series,
    Audiobook,
    MusicAlbum
}

public static class ContentTypeExtensions
{
    public static Type GetType(ContentType contentType) => contentType switch
    {
        ContentType.Movie => typeof(Movie),
        ContentType.Series => typeof(Series),
        ContentType.Audiobook => typeof(Audiobook),
        ContentType.MusicAlbum => typeof(MusicAlbum),
        _ => throw new ArgumentOutOfRangeException(nameof(contentType), contentType, null)
    };
}
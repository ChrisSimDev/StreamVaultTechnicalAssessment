using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using StreamVaultTechnicalAssessment.DTOs.Content;
using StreamVaultTechnicalAssessment.Enums;

namespace StreamVaultTechnicalAssessment.Models;

public class ContentItemViewModel
{
    public ContentType ContentType { get; set; } = ContentType.Movie;
    public string? Id { get; set; }

    // Validated in the controller for whichever type is active 
    // Required properties like title cause the unused content models to fail validation
    [ValidateNever]
    public Movie Movie { get; set; } = new();

    [ValidateNever]
    public Series Series { get; set; } = new();

    [ValidateNever]
    public Audiobook Audiobook { get; set; } = new();

    [ValidateNever]
    public MusicAlbum MusicAlbum { get; set; } = new();
}

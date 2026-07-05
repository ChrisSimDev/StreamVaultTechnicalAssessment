using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamVaultTechnicalAssessment.dtos.content;
using StreamVaultTechnicalAssessment.enums;
using StreamVaultTechnicalAssessment.services;

namespace StreamVaultTechnicalAssessment.Pages;

public class ContentItemModel(ContentAccessService contentAccessService) : PageModel
{
    [BindProperty(SupportsGet = true)]
    public ContentType ContentType { get; set; } = ContentType.Movie;

    [BindProperty(SupportsGet = true)]
    public string? Id { get; init; } = null;

    [BindProperty]
    public Movie Movie { get; set; } = new();

    [BindProperty]
    public Series Series { get; set; } = new();

    [BindProperty]
    public Audiobook Audiobook { get; set; } = new();

    [BindProperty]
    public MusicAlbum MusicAlbum { get; set; } = new();

    public void OnGet()
    {
        if (string.IsNullOrEmpty(this.Id))
        {
            return;
        }

        var content = contentAccessService.GetContentById(this.Id);
        switch (content)
        {
            case Movie movie:
                this.Movie = movie;
                this.ContentType = ContentType.Movie;
                break;
            case Series series:
                this.Series = series;
                this.ContentType = ContentType.Series;
                break;
            case Audiobook audiobook:
                this.Audiobook = audiobook;
                this.ContentType = ContentType.Audiobook;
                break;
            case MusicAlbum musicAlbum:
                this.MusicAlbum = musicAlbum;
                this.ContentType = ContentType.MusicAlbum;
                break;
        }
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Content content = ContentType switch
        {
            ContentType.Movie => this.Movie,
            ContentType.Series => this.Series,
            ContentType.Audiobook => this.Audiobook,
            ContentType.MusicAlbum => this.MusicAlbum,
            _ => throw new InvalidOperationException("Unsupported content type")
        };

        // Null ids mean no id was provided, so we can assume new
        if (string.IsNullOrEmpty(this.Id))
        {
            contentAccessService.AddContent(content);
        }
        else
        {
            contentAccessService.UpdateContent(content);
        }

        // This has the bonus advantage of meaning you can't double submit the form and have duplicate id errors.
        return RedirectToPage("/Index");
    }

    public IActionResult OnPostDelete()
    {
        if (string.IsNullOrEmpty(this.Id))
        {
            return Page();
        }
        
        var content = contentAccessService.GetContentById(this.Id);
        if (content != null)
        {
            contentAccessService.DeleteContent(content);
        }


        return RedirectToPage("/Index");
    }
}

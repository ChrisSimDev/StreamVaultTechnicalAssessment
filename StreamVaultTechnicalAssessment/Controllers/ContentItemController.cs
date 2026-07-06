using Microsoft.AspNetCore.Mvc;
using StreamVaultTechnicalAssessment.Models;
using StreamVaultTechnicalAssessment.Enums;
using StreamVaultTechnicalAssessment.Services;
using StreamVaultTechnicalAssessment.DTOs.Content;

namespace StreamVaultTechnicalAssessment.Controllers;

public class ContentItemController(ContentAccessService contentAccessService) : Controller
{
    [HttpGet]
    public IActionResult Index(string? id, ContentType contentType = ContentType.Movie)
    {
        var model = new ContentItemViewModel { Id = id, ContentType = contentType };

        if (string.IsNullOrEmpty(id))
        {
            return View(model);
        }

        var content = contentAccessService.GetContentById(id);
        switch (content)
        {
            case Movie movie:
                model.Movie = movie;
                model.ContentType = ContentType.Movie;
                break;
            case Series series:
                model.Series = series;
                model.ContentType = ContentType.Series;
                break;
            case Audiobook audiobook:
                model.Audiobook = audiobook;
                model.ContentType = ContentType.Audiobook;
                break;
            case MusicAlbum musicAlbum:
                model.MusicAlbum = musicAlbum;
                model.ContentType = ContentType.MusicAlbum;
                break;
        }

        return View(model);
    }

    [HttpPost]
    public IActionResult Index(ContentItemViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        Content content = model.ContentType switch
        {
            ContentType.Movie => model.Movie,
            ContentType.Series => model.Series,
            ContentType.Audiobook => model.Audiobook,
            ContentType.MusicAlbum => model.MusicAlbum,
            _ => throw new InvalidOperationException("Unsupported content type")
        };

        // Null ids mean no id was provided, so we can assume new
        if (string.IsNullOrEmpty(model.Id))
        {
            contentAccessService.AddContent(content);
        }
        else
        {
            contentAccessService.UpdateContent(content);
        }

        // This has the bonus advantage of meaning you can't double submit the form and have duplicate id errors.
        return RedirectToAction("Index", "ContentList");
    }

    [HttpPost]
    public IActionResult Delete(string? id)
    {
        if (!string.IsNullOrEmpty(id))
        {
            var content = contentAccessService.GetContentById(id);
            if (content != null)
            {
                contentAccessService.DeleteContent(content);
            }
        }

        return RedirectToAction("Index", "ContentList");
    }
}

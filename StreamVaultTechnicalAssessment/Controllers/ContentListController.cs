using Microsoft.AspNetCore.Mvc;
using StreamVaultTechnicalAssessment.dtos.search;
using StreamVaultTechnicalAssessment.enums;
using StreamVaultTechnicalAssessment.services;

namespace StreamVaultTechnicalAssessment.Controllers;

public class ContentListController(ContentAccessService contentAccessService) : Controller
{
    public IActionResult Index(ContentType? contentType, string? searchTerm)
    {
        var model = new ContentIndexViewModel
        {
            ContentList = contentAccessService.GetList(contentType, searchTerm),
            ContentType = contentType,
            SearchTerm = searchTerm
        };

        return View(model);
    }
}

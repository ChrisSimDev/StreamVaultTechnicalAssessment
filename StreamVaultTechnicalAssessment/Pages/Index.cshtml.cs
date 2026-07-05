using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StreamVaultTechnicalAssessment.dtos.search;
using StreamVaultTechnicalAssessment.enums;
using StreamVaultTechnicalAssessment.services;

namespace StreamVaultTechnicalAssessment.Pages
{
    public class IndexModel(ContentAccessService contentAccessService) : PageModel
    {
        public List<ContentListItem> ContentList = [];

        [BindProperty(SupportsGet = true)]
        public ContentType? ContentType { get; set; } = null;

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; } = null;

        public void OnGet()
            => this.Search();

        private void Search()
            => this.ContentList = contentAccessService.GetList(this.ContentType, this.SearchTerm);
    }
}

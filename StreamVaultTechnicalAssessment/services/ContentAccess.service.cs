using Microsoft.EntityFrameworkCore;
using StreamVaultTechnicalAssessment.data;
using StreamVaultTechnicalAssessment.dtos.content;
using StreamVaultTechnicalAssessment.dtos.search;
using StreamVaultTechnicalAssessment.enums;

namespace StreamVaultTechnicalAssessment.services;

public class ContentAccessService(ContentDbContext context)
{

    public List<ContentListItem> GetList(ContentType? contentType = null, string? searchTerm = null)
    {
        // This lets us build up a singular query based upon inputs
        IQueryable<Content> query = context.Contents.AsQueryable();

        // Content type
        if (contentType.HasValue)
        {
            query = contentType switch
            {
                ContentType.Movie => query.Where(c => c is Movie),
                ContentType.Series => query.Where(c => c is Series),
                ContentType.Audiobook => query.Where(c => c is Audiobook),
                ContentType.MusicAlbum => query.Where(c => c is MusicAlbum),
                _ => query // Default shouldnt happen but falls through to return all content
            };
        }

        // Search term
        if (!string.IsNullOrEmpty(searchTerm))
        { 
            // Ive used a Like query to allow partial and case insensitive searching
            query = query.Where(c => EF.Functions.Like(c.Title, $"%{searchTerm}%"));
        }

        // Selects the data for the list in the query to reduce the amount of data being returned from the database
        IQueryable<ContentListItem> queryListItems = query.Select(c => new ContentListItem(
            c.Id,
            c.Title,
            EF.Property<ContentType>(c, "ContentType")
        ));

        return queryListItems.ToList();
    }

    public Content? GetContentById(string id)
        => context.Contents.Find(id);

    public void AddContent(Content content)
    {
        context.Contents.Add(content);
        context.SaveChanges();
    }

    public void UpdateContent(Content content)
    {
        context.Contents.Update(content);
        context.SaveChanges();
    }

    public void DeleteContent(Content content)
    {
        context.Contents.Remove(content);
        context.SaveChanges();
    }
}
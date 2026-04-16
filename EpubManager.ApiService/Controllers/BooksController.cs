using EpubManager.Data.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EpubManager.ApiService.Controllers;

[ApiController]
[Route("calibre/books")]
public class BooksController(CalibreDbContext dbContext) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<CalibreBookDto>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IReadOnlyList<CalibreBookDto>>> GetBooks(CancellationToken cancellationToken)
    {
        var books = await dbContext.Books
            .AsNoTracking()
            .OrderBy(b => b.Title)
            .Take(20)
            .Select(b => new CalibreBookDto(
                b.Id,
                b.Title,
                b.AuthorSort,
                b.Path,
                b.Timestamp))
            .ToListAsync(cancellationToken);

        return Ok(books);
    }
}

public sealed record CalibreBookDto(
    int Id,
    string Title,
    string? AuthorSort,
    string Path,
    DateTimeOffset? Timestamp);

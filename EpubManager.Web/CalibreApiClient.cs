namespace EpubManager.Web;

public class CalibreApiClient(HttpClient httpClient)
{
    public async Task<IReadOnlyList<CalibreBook>> GetBooksAsync(CancellationToken cancellationToken = default)
    {
        using var response = await httpClient.GetAsync("/calibre/books", cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<IReadOnlyList<CalibreBook>>(cancellationToken)
            ?? [];
    }
}

public record CalibreBook(
    int Id,
    string Title,
    string? AuthorSort,
    string Path,
    DateTimeOffset? Timestamp);

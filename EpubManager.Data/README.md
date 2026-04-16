# Calibre EF Core setup

This project contains a database-first Entity Framework Core model for a Calibre SQLite library.

## Connected database

The API is configured to use:

- `C:\Epub\CalibreBibliotheek\metadata.db`

Connection string key:

- `ConnectionStrings:Calibre` in `EpubManager.ApiService/appsettings.Development.json`

Current value is read-only:

- `Data Source=C:\Epub\CalibreBibliotheek\metadata.db;Mode=ReadOnly`

## Generated model

- DbContext: `Db/CalibreDbContext.cs`
- Entities: `Entities/*.cs`

## Re-scaffold command

Calibre uses some SQLite virtual-table/functions that fail full reverse-engineering.
The command below scaffolds the core metadata tables that work reliably:

```powershell
dotnet ef dbcontext scaffold "Data Source=C:\Epub\CalibreBibliotheek\metadata.db" Microsoft.EntityFrameworkCore.Sqlite --project "D:\EpubManager\EpubManager.Data\EpubManager.Data.csproj" --startup-project "D:\EpubManager\EpubManager.ApiService\EpubManager.ApiService.csproj" --context CalibreDbContext --context-dir Db --output-dir Entities --use-database-names --no-onconfiguring --table authors --table books --table books_authors_link --table books_languages_link --table books_publishers_link --table books_ratings_link --table books_series_link --table books_tags_link --table comments --table conversion_options --table custom_columns --table data --table feeds --table identifiers --table languages --table library_id --table metadata_dirtied --table preferences --table publishers --table ratings --table series --table tags --force
```


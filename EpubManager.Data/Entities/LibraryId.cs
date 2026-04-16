using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class LibraryId
{
    public int Id { get; set; }

    public string Uuid { get; set; } = null!;
}

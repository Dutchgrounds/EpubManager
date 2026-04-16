using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Feed
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Script { get; set; } = null!;
}

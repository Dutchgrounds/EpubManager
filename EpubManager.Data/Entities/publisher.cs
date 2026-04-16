using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Publisher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Sort { get; set; }

    public string Link { get; set; } = null!;
}

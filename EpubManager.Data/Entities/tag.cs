using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Tag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Link { get; set; } = null!;
}

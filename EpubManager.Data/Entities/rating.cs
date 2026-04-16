using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Rating
{
    public int Id { get; set; }

    public int? Rating1 { get; set; }

    public string Link { get; set; } = null!;
}

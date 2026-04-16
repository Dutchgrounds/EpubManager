using System;
using System.Collections.Generic;

namespace EpubManager.Data.Entities;

public partial class Comment
{
    public int Id { get; set; }

    public int Book { get; set; }

    public string Text { get; set; } = null!;
}
